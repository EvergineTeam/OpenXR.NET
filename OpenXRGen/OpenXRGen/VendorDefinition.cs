using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OpenXRGen
{
    public class VendorDefinition
    {
        public string Name;
        public string Id;
        public string Comment;

        public static VendorDefinition FromXML(XElement elem)
        {
            VendorDefinition vendor = new VendorDefinition();
            vendor.Name = elem.Attribute("name").Value;
            vendor.Id = elem.Attribute("id").Value;
            vendor.Comment = elem.Attribute("comment").Value;

            return vendor;
        }
    }
}
