using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace CPT.Models
{

    /// <summary>
    /// Объектная модель Земельного участка
    /// </summary>
    [XmlType(TypeName = "land_record")]
    public class Parcel: IEntity
    {
        public string GetId() => this.Object.CommonData.CadNumber;
        
        [XmlElement(ElementName = "object")]
        public Object_ Object { get; set; }
        public Parcel() { }

        public void Serialize(string filename)
        {
            Data.Serialize(filename, this, System.IO.FileMode.Append);
        }
    }
}
