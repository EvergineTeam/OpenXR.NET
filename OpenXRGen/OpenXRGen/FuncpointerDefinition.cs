using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OpenXRGen
{
    public class FuncpointerDefinition
    {
        public string Name;
        public string Type;
        public List<Parameter> Parameters = new List<Parameter>();

        public static FuncpointerDefinition FromXML(XElement elem)
        {
            string[] filter = elem.Value.Split(';');
            string elemText = filter.Where(s => s.TrimEnd() != string.Empty && !string.IsNullOrEmpty(s)).Last(); 

            string description = Regex.Replace(elemText, @"<\/?type>", "");
            FuncpointerDefinition funcpointer = new FuncpointerDefinition();
            funcpointer.Name = elem.Element("name").Value;
            Match pointerType = Regex.Match(description, @"typedef\s+(\w+[*]?)");
            funcpointer.Type = pointerType.Groups[1].Value;

            string pattern = @"((\w+[*]?)\s+(\w+),|(\w+[*]?)\s+(\w+)\))";
            foreach (Match match in Regex.Matches(description, pattern))
            {
                Parameter p = new Parameter();
                if (match.Groups[2].Value != string.Empty)
                {
                    p.Type = match.Groups[2].Value;
                    p.Name = match.Groups[3].Value;
                }
                else
                {
                    p.Type = match.Groups[4].Value;
                    p.Name = match.Groups[5].Value;
                }

                funcpointer.Parameters.Add(p);
            }

            return funcpointer;
        }
    }

    public class Parameter
    {
        public string Type;
        public string Name;
    }
}
