using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CPT.Models
{
    [XmlType(TypeName = "ArrayOfAll_record")]
    public class ArrayOfEntities
    {
        [XmlElement(ElementName = "land_records")]
        public ArrayOfParcel parcelArray;

        [XmlElement(ElementName = "build_records")]
        public ArrayOfBuild buildArray;
        [XmlElement(ElementName = "construction_records")]
        public ArrayOfConstruction constructionArray;

        [XmlElement(ElementName = "spatial_data")]
        public ArrayOfSpatialData spatialDataArray;

        [XmlElement(ElementName = "municipal_boundaries")]
        public ArrayOfBound boundArray;

        [XmlElement(ElementName = "zones_and_territories_boundaries")]
        public ArrayOfZone zoneArray;

        public ArrayOfEntities() { }
        public ArrayOfEntities(List<IEntity> entities) 
        {
            parcelArray = new ArrayOfParcel();
            buildArray = new ArrayOfBuild();
            constructionArray = new ArrayOfConstruction();
            spatialDataArray = new ArrayOfSpatialData();
            boundArray = new ArrayOfBound();
            zoneArray = new ArrayOfZone();
            foreach (IEntity entity in entities)
            {
                if (entity is Bound)
                {
                    this.boundArray.entities.Append((Bound)entity);
                }
                else if (entity is Parcel)
                {
                    this.parcelArray.entities.Append((Parcel)entity);
                }
                else if (entity is Build)
                {
                    this.buildArray.entities.Append((Build)entity);
                }
                else if (entity is Construction)
                {
                    this.constructionArray.entities.Append((Construction)entity);
                }
                else if (entity is SpatialData)
                {
                    this.spatialDataArray.entities.Append((SpatialData)entity);
                }
                else if (entity is Zone)
                {
                    this.zoneArray.entities.Append((Zone)entity);
                }
            }
        }
    }
}
