using System.Xml.Serialization;

namespace CPT.Models
{
    [XmlType(TypeName = "ArrayOfBuild_record")]
    public class ArrayOfBuild
    {
        [XmlElement(ElementName = "build_record")]
        public Build[] entities;

        public ArrayOfBuild() { }
    }
}