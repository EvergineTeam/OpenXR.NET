using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenXRGen
{
    public class OpenXRVersion
    {
        public List<ConstantDefinition> Constants = new List<ConstantDefinition>();
        public List<FuncpointerDefinition> FuncPointers = new List<FuncpointerDefinition>();
        public List<EnumDefinition> Enums = new List<EnumDefinition>();
        public List<StructureDefinition> Structs = new List<StructureDefinition>();
        public List<StructureDefinition> Unions = new List<StructureDefinition>();
        public List<HandleDefinition> Handles = new List<HandleDefinition>();
        public List<AtomDefinition> Atoms = new List<AtomDefinition>();
        public List<CommandDefinition> Commands = new List<CommandDefinition>();

        public static OpenXRVersion FromSpec(OpenXRSpecification spec, string versionName, IEnumerable<ExtensionDefinition> extensions)
        {
            OpenXRVersion version = new OpenXRVersion();
            version.Constants = spec.Constants;
            version.FuncPointers = spec.FuncPointers;
            version.Handles = spec.Handles;
            version.Atoms = spec.Atoms;
            version.Unions = spec.Unions;
            version.Structs = spec.Structs;
            version.Enums = spec.Enums;

            for (int i = 0; i < spec.Features.Count; i++)
            {
                FeatureDefinition feature = spec.Features[i];

                // Extend Enums
                foreach (var enumType in feature.Enums)
                {
                    if (enumType.Extends != null && enumType.Alias == null)
                    {
                        string name = enumType.Extends;
                        var enumDefinition = spec.Enums.Find(c => c.Name == name);

                        EnumValue newValue = new EnumValue();
                        newValue.Name = enumType.Name;
                        newValue.Value = int.Parse(enumType.Value);
                        enumDefinition.Values.Add(newValue);
                    }
                }

                // Add commands
                foreach (var command in feature.Commands)
                {
                    var commandDefinition = FindCommand(spec, command);
                    version.Commands.Add(commandDefinition);
                }

                if (feature.Name == versionName)
                {
                    break;
                }
            }

            foreach (var extension in extensions)
            {
                if (extension.Supported == "disabled")
                {
                    continue;
                }

                // Add Constant
                foreach (var constantType in extension.Constants)
                {
                    if (!version.Constants.Exists(c => c.Name == constantType.Name))
                    {
                        ConstantDefinition newConstant = new ConstantDefinition();
                        newConstant.Name = constantType.Name;
                        newConstant.Value = constantType.Value;
                        newConstant.Alias = constantType.Alias;

                        if (constantType.Value != null)
                        {
                            newConstant.Type = ConstantDefinition.ParseType(constantType.Value);
                        }

                        version.Constants.Add(newConstant);
                    }
                }

                // Add Enums
                foreach (var enumType in extension.Enums)
                {
                    if (enumType.Extends != null && enumType.Alias == null)
                    {
                        string name = enumType.Extends;
                        var enumDefinition = spec.Enums.Find(c => c.Name == name);


                        if (!enumDefinition.Values.Exists(e => e.Name == enumType.Name))
                        {
                            EnumValue newValue = new EnumValue();
                            newValue.Name = enumType.Name;
                            newValue.Value = int.Parse(enumType.Value);
                            enumDefinition.Values.Add(newValue);
                        }
                    }
                }

                // Add commands
                foreach (var command in extension.Commands)
                {
                    var commandDefinition = FindCommand(spec, command);

                    if (commandDefinition == null)
                        continue;

                    if(!version.Commands.Exists(c => c.Prototype.Name == command))
                        version.Commands.Add(commandDefinition);
                }
            }

            return version;
        }

        private static CommandDefinition FindCommand(OpenXRSpecification spec, string name)
        {
            if (spec.Alias.TryGetValue(name, out string alias))
            {
                // An alias is a different entry point, so it is generated with its own name and the aliased signature.
                return spec.Commands.Find(c => c.Prototype.Name == alias)?.CloneWithName(name);
            }

            return spec.Commands.Find(c => c.Prototype.Name == name);
        }
    }
}
