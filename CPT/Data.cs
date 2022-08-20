using CPT.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CPT
{
    public static class Data
    {
        /// <summary>
        /// Объектная модель главного xml-документа
        /// </summary>
        public static extract_cadastral_plan_territory Catalog { get; set; }

        public static extract_cadastral_plan_territory GetCatalog()
        {
            if (Catalog == null)
            {
                string xml = File.ReadAllText(Environment.CurrentDirectory + "\\24_21_1003001_2017-05-29_kpt11.xml");
                Catalog = xml.ParseXML<extract_cadastral_plan_territory>();
            }
            return Catalog;
        }

        public static Parcel[] Parcels { get; set; }
        
        public static void Init()
        {
            var catalog = GetCatalog();

            var land_records = catalog.cadastral_blocks.cadastral_block.record_data.base_data.land_records;
            ArrayOfParcel arrayOfParcel = GetEntitiesFromCatalog(land_records, typeof(ArrayOfParcel)) as ArrayOfParcel;
            Parcels = arrayOfParcel.entities;
        }

        private static object GetEntitiesFromCatalog(object[] records, Type type)
        {
            string tmp_filename = "tmp.xml";
            Serialize(tmp_filename, records);
            return Deserialize(tmp_filename, type);
        }
        public static void Serialize(string filename, object records, FileMode fileMode = FileMode.OpenOrCreate)
        {
            XmlSerializer xmlSerializer;
            using (FileStream fs = new FileStream(filename, fileMode))
            {
                xmlSerializer = new XmlSerializer(records.GetType());
                xmlSerializer.Serialize(fs, records);
                fs.Close();
            }
        }
        private static object Deserialize(string filename, Type type)
        {
            XmlSerializer xmlSerializer;
            object arrayOfEntity;
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                xmlSerializer = new XmlSerializer(type);
                arrayOfEntity = xmlSerializer.Deserialize(fs);
                fs.Close();
            }
            return arrayOfEntity;
        }
    }
}
