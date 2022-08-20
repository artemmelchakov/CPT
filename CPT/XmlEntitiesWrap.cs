using CPT.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CPT
{
    [XmlType(TypeName = "records")]
    public class XmlEntitiesWrap
    {
        [XmlArray(ElementName = "land_records")]
        public List<Parcel> Parcels { get; set; }

        [XmlArray(ElementName = "build_records")]
        public List<Build> Builds { get; set; }

        [XmlArray(ElementName = "construction_records")]
        public List<Construction> Constructions { get; set; }

        [XmlArray(ElementName = "spatial_data")]
        public List<SpatialDataEntity> SpatialDataEntities { get; set; }

        [XmlArray(ElementName = "municipal_boundaries")]
        public List<Bound> Bounds { get; set; }

        [XmlArray(ElementName = "zones_and_territories_boundaries")]
        public List<Zone> Zones { get; set; }
    }
}
