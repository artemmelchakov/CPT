using System.Xml.Serialization;

namespace CPT.Models
{
    [XmlType(TypeName = "ArrayOfzones_and_territories_record")]
    public class ArrayOfZone
    {
        [XmlElement(ElementName = "zones_and_territories_record")]
        public Zone[] entities;

        public ArrayOfZone() { }
    }
}