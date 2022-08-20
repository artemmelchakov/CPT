using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CPT.Models
{
    [XmlType(TypeName = "object")]
    public class Object_
    {
        public class CommonData_
        {
            public class Type_
            {
                [XmlElement(ElementName = "code")]
                public string Code { get; set; }
                [XmlElement(ElementName = "value")]
                public string Value { get; set; }
                public Type_() { }
            }
            [XmlElement(ElementName = "type")]
            public Type_ Type { get; set; }
            [XmlElement(ElementName = "cad_number")]
            public string CadNumber { get; set; }
            public CommonData_() { }
        }
        [XmlElement(ElementName = "common_data")]
        public CommonData_ CommonData { get; set; }
        public class Subtype_
        {
            [XmlElement(ElementName = "code")]
            public string Code { get; set; }
            [XmlElement(ElementName = "value")]
            public string Value { get; set; }
            public Subtype_() { }
        }
        [XmlElement(ElementName = "subtype")]
        public Subtype_ Subtype { get; set; }
        public Object_() { }
    }
}
