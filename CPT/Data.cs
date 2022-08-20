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
        private static extract_cadastral_plan_territory _catalog;

        /// <summary>
        /// Получаем информацию от главного xml файла и десериализуем его 
        /// в объект типа extract_cadastral_plan_territory
        /// </summary>
        /// <returns></returns>
        public static extract_cadastral_plan_territory GetCatalog()
        {
            if (_catalog == null)
            {
                string xml = File.ReadAllText(Environment.CurrentDirectory + "\\24_21_1003001_2017-05-29_kpt11.xml");
                _catalog = xml.ParseXML<extract_cadastral_plan_territory>();
            }
            return _catalog;
        }

        public static Parcel[] Parcels { get; set; }
        public static Build[] Builds { get; set; }
        public static Construction[] Constructions { get; set; }
        public static SpatialDataEntity[] SpatialData { get; set; }
        public static Bound[] Bounds { get; set; }
        public static Zone[] Zones { get; set; }

        /// <summary>
        /// Инициализация:
        /// Получение объектной модели главного xml-документа
        /// и расфасовка нужных для работы массивов данных
        /// </summary>
        public static void Init()
        {
            var catalog = GetCatalog();
            Parcels = catalog.cadastral_blocks.cadastral_block.record_data.base_data.land_records;
            Builds = catalog.cadastral_blocks.cadastral_block.record_data.base_data.build_records;
            Constructions = catalog.cadastral_blocks.cadastral_block.record_data.base_data.construction_records;
            SpatialData = catalog.cadastral_blocks.cadastral_block.spatial_data;
            Bounds = catalog.cadastral_blocks.cadastral_block.municipal_boundaries;
            Zones = catalog.cadastral_blocks.cadastral_block.zones_and_territories_boundaries;
        }
    }
}
