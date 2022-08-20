using System.Xml.Serialization;

namespace CPT.Models
{
    [XmlType(TypeName = "ArrayOfEntity_spatial")]
    public class ArrayOfSpatialData
    {
        [XmlElement(ElementName = "entity_spatial")]
        public SpatialData[] entities;

        public ArrayOfSpatialData() { }
    }
}