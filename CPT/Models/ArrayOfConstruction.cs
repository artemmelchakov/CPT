using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CPT.Models
{
    [XmlType(TypeName = "ArrayOfConstruction_record")]
    public class ArrayOfConstruction
    {
        [XmlElement(ElementName = "construction_record")]
        public Construction[] entities;

        public ArrayOfConstruction() { }
    }
}
