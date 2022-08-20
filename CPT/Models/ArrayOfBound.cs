using System.Xml.Serialization;

namespace CPT.Models
{
    [XmlType(TypeName = "ArrayOfMunicipal_boundary_record")]
    public class ArrayOfBound
    {
        [XmlElement(ElementName = "municipal_boundary_record")]
        public Bound[] entities = new Bound[100];

        public ArrayOfBound() { }
    }
}