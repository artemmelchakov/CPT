using System.Xml;
using System.Xml.Serialization;

namespace CPT.Models
{
    [XmlType(TypeName = "ArrayOfLand_record")]
    public class ArrayOfParcel
    {
        [XmlElement(ElementName = "land_record")]
        public Parcel[] entities = new Parcel[100];

        public ArrayOfParcel() { }
    }
}
