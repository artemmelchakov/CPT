using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPT.Models
{

    // Примечание. Для запуска созданного кода может потребоваться NET Framework версии 4.5 или более поздней версии и .NET Core или Standard версии 2.0 или более поздней.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class extract_cadastral_plan_territory
    {

        private extract_cadastral_plan_territoryDetails_statement details_statementField;

        private extract_cadastral_plan_territoryDetails_request details_requestField;

        private extract_cadastral_plan_territoryCadastral_blocks cadastral_blocksField;

        /// <remarks/>
        public extract_cadastral_plan_territoryDetails_statement details_statement
        {
            get
            {
                return this.details_statementField;
            }
            set
            {
                this.details_statementField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryDetails_request details_request
        {
            get
            {
                return this.details_requestField;
            }
            set
            {
                this.details_requestField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocks cadastral_blocks
        {
            get
            {
                return this.cadastral_blocksField;
            }
            set
            {
                this.cadastral_blocksField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryDetails_statement
    {

        private extract_cadastral_plan_territoryDetails_statementGroup_top_requisites group_top_requisitesField;

        /// <remarks/>
        public extract_cadastral_plan_territoryDetails_statementGroup_top_requisites group_top_requisites
        {
            get
            {
                return this.group_top_requisitesField;
            }
            set
            {
                this.group_top_requisitesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryDetails_statementGroup_top_requisites
    {

        private string organ_registr_rightsField;

        private System.DateTime date_formationField;

        private string registration_numberField;

        /// <remarks/>
        public string organ_registr_rights
        {
            get
            {
                return this.organ_registr_rightsField;
            }
            set
            {
                this.organ_registr_rightsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime date_formation
        {
            get
            {
                return this.date_formationField;
            }
            set
            {
                this.date_formationField = value;
            }
        }

        /// <remarks/>
        public string registration_number
        {
            get
            {
                return this.registration_numberField;
            }
            set
            {
                this.registration_numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryDetails_request
    {

        private System.DateTime date_received_requestField;

        private System.DateTime date_receipt_request_reg_authority_rightsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime date_received_request
        {
            get
            {
                return this.date_received_requestField;
            }
            set
            {
                this.date_received_requestField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
        public System.DateTime date_receipt_request_reg_authority_rights
        {
            get
            {
                return this.date_receipt_request_reg_authority_rightsField;
            }
            set
            {
                this.date_receipt_request_reg_authority_rightsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocks
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_block cadastral_blockField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_block cadastral_block
        {
            get
            {
                return this.cadastral_blockField;
            }
            set
            {
                this.cadastral_blockField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_block
    {

        private string cadastral_numberField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockArea_quarter area_quarterField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_data record_dataField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_data spatial_dataField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_record[] municipal_boundariesField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_record[] zones_and_territories_boundariesField;

        /// <remarks/>
        public string cadastral_number
        {
            get
            {
                return this.cadastral_numberField;
            }
            set
            {
                this.cadastral_numberField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockArea_quarter area_quarter
        {
            get
            {
                return this.area_quarterField;
            }
            set
            {
                this.area_quarterField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_data record_data
        {
            get
            {
                return this.record_dataField;
            }
            set
            {
                this.record_dataField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_data spatial_data
        {
            get
            {
                return this.spatial_dataField;
            }
            set
            {
                this.spatial_dataField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("municipal_boundary_record", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_record[] municipal_boundaries
        {
            get
            {
                return this.municipal_boundariesField;
            }
            set
            {
                this.municipal_boundariesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("zones_and_territories_record", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_record[] zones_and_territories_boundaries
        {
            get
            {
                return this.zones_and_territories_boundariesField;
            }
            set
            {
                this.zones_and_territories_boundariesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockArea_quarter
    {

        private ushort areaField;

        private byte unitField;

        /// <remarks/>
        public ushort area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        public byte unit
        {
            get
            {
                return this.unitField;
            }
            set
            {
                this.unitField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_data
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_data base_dataField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_data base_data
        {
            get
            {
                return this.base_dataField;
            }
            set
            {
                this.base_dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_data
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_record[] land_recordsField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_record[] build_recordsField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_record[] construction_recordsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("land_record", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_record[] land_records
        {
            get
            {
                return this.land_recordsField;
            }
            set
            {
                this.land_recordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("build_record", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_record[] build_records
        {
            get
            {
                return this.build_recordsField;
            }
            set
            {
                this.build_recordsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("construction_record", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_record[] construction_records
        {
            get
            {
                return this.construction_recordsField;
            }
            set
            {
                this.construction_recordsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName = "land_record"/*, AnonymousType = true*/)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_record
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObject objectField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_links cad_linksField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParams paramsField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_location address_locationField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCost costField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_location contours_locationField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObject @object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_links cad_links
        {
            get
            {
                return this.cad_linksField;
            }
            set
            {
                this.cad_linksField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParams @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_location address_location
        {
            get
            {
                return this.address_locationField;
            }
            set
            {
                this.address_locationField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCost cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_location contours_location
        {
            get
            {
                return this.contours_locationField;
            }
            set
            {
                this.contours_locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObject
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectCommon_data common_dataField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectSubtype subtypeField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectCommon_data common_data
        {
            get
            {
                return this.common_dataField;
            }
            set
            {
                this.common_dataField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectSubtype subtype
        {
            get
            {
                return this.subtypeField;
            }
            set
            {
                this.subtypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectCommon_data
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectCommon_dataType typeField;

        private string cad_numberField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectCommon_dataType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string cad_number
        {
            get
            {
                return this.cad_numberField;
            }
            set
            {
                this.cad_numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectCommon_dataType
    {

        private uint codeField;

        private string valueField;

        /// <remarks/>
        public uint code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordObjectSubtype
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_links
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_linksCommon_land common_landField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_linksCommon_land common_land
        {
            get
            {
                return this.common_landField;
            }
            set
            {
                this.common_landField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_linksCommon_land
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_linksCommon_landCommon_land_cad_number common_land_cad_numberField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_linksCommon_landCommon_land_cad_number common_land_cad_number
        {
            get
            {
                return this.common_land_cad_numberField;
            }
            set
            {
                this.common_land_cad_numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCad_linksCommon_landCommon_land_cad_number
    {

        private string cad_numberField;

        /// <remarks/>
        public string cad_number
        {
            get
            {
                return this.cad_numberField;
            }
            set
            {
                this.cad_numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParams
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsCategory categoryField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_use permitted_useField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsArea areaField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsCategory category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_use permitted_use
        {
            get
            {
                return this.permitted_useField;
            }
            set
            {
                this.permitted_useField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsArea area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsCategory
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsCategoryType typeField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsCategoryType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsCategoryType
    {

        private uint codeField;

        private string valueField;

        /// <remarks/>
        public uint code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_use
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_usePermitted_use_established permitted_use_establishedField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_usePermitted_use_established permitted_use_established
        {
            get
            {
                return this.permitted_use_establishedField;
            }
            set
            {
                this.permitted_use_establishedField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_usePermitted_use_established
    {

        private string by_documentField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_usePermitted_use_establishedLand_use land_useField;

        /// <remarks/>
        public string by_document
        {
            get
            {
                return this.by_documentField;
            }
            set
            {
                this.by_documentField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_usePermitted_use_establishedLand_use land_use
        {
            get
            {
                return this.land_useField;
            }
            set
            {
                this.land_useField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsPermitted_usePermitted_use_establishedLand_use
    {

        private ulong codeField;

        private bool codeFieldSpecified;

        private string valueField;

        /// <remarks/>
        public ulong code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool codeSpecified
        {
            get
            {
                return this.codeFieldSpecified;
            }
            set
            {
                this.codeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordParamsArea
    {

        private decimal valueField;

        private decimal inaccuracyField;

        private bool inaccuracyFieldSpecified;

        /// <remarks/>
        public decimal value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public decimal inaccuracy
        {
            get
            {
                return this.inaccuracyField;
            }
            set
            {
                this.inaccuracyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool inaccuracySpecified
        {
            get
            {
                return this.inaccuracyFieldSpecified;
            }
            set
            {
                this.inaccuracyFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_location
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddress_type address_typeField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddress addressField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationRel_position rel_positionField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddress_type address_type
        {
            get
            {
                return this.address_typeField;
            }
            set
            {
                this.address_typeField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddress address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationRel_position rel_position
        {
            get
            {
                return this.rel_positionField;
            }
            set
            {
                this.rel_positionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddress_type
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddress
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fias address_fiasField;

        private string readable_addressField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fias address_fias
        {
            get
            {
                return this.address_fiasField;
            }
            set
            {
                this.address_fiasField = value;
            }
        }

        /// <remarks/>
        public string readable_address
        {
            get
            {
                return this.readable_addressField;
            }
            set
            {
                this.readable_addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fias
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlement level_settlementField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_level detailed_levelField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlement level_settlement
        {
            get
            {
                return this.level_settlementField;
            }
            set
            {
                this.level_settlementField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_level detailed_level
        {
            get
            {
                return this.detailed_levelField;
            }
            set
            {
                this.detailed_levelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlement
    {

        private uint okatoField;

        private ulong kladrField;

        private uint postal_codeField;

        private bool postal_codeFieldSpecified;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementRegion regionField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict districtField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementSoviet_village soviet_villageField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementCity cityField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementLocality localityField;

        /// <remarks/>
        public uint okato
        {
            get
            {
                return this.okatoField;
            }
            set
            {
                this.okatoField = value;
            }
        }

        /// <remarks/>
        public ulong kladr
        {
            get
            {
                return this.kladrField;
            }
            set
            {
                this.kladrField = value;
            }
        }

        /// <remarks/>
        public uint postal_code
        {
            get
            {
                return this.postal_codeField;
            }
            set
            {
                this.postal_codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postal_codeSpecified
        {
            get
            {
                return this.postal_codeFieldSpecified;
            }
            set
            {
                this.postal_codeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementRegion region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict district
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementSoviet_village soviet_village
        {
            get
            {
                return this.soviet_villageField;
            }
            set
            {
                this.soviet_villageField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementCity city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementLocality locality
        {
            get
            {
                return this.localityField;
            }
            set
            {
                this.localityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementRegion
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict
    {

        private string type_districtField;

        private string name_districtField;

        /// <remarks/>
        public string type_district
        {
            get
            {
                return this.type_districtField;
            }
            set
            {
                this.type_districtField = value;
            }
        }

        /// <remarks/>
        public string name_district
        {
            get
            {
                return this.name_districtField;
            }
            set
            {
                this.name_districtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementSoviet_village
    {

        private string name__soviet_villageField;

        /// <remarks/>
        public string name__soviet_village
        {
            get
            {
                return this.name__soviet_villageField;
            }
            set
            {
                this.name__soviet_villageField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementCity
    {

        private string type_cityField;

        private string name_cityField;

        /// <remarks/>
        public string type_city
        {
            get
            {
                return this.type_cityField;
            }
            set
            {
                this.type_cityField = value;
            }
        }

        /// <remarks/>
        public string name_city
        {
            get
            {
                return this.name_cityField;
            }
            set
            {
                this.name_cityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasLevel_settlementLocality
    {

        private string type_localityField;

        private string name_localityField;

        /// <remarks/>
        public string type_locality
        {
            get
            {
                return this.type_localityField;
            }
            set
            {
                this.type_localityField = value;
            }
        }

        /// <remarks/>
        public string name_locality
        {
            get
            {
                return this.name_localityField;
            }
            set
            {
                this.name_localityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_level
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelStreet streetField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelApartment apartmentField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelLevel1 level1Field;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelStreet street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelApartment apartment
        {
            get
            {
                return this.apartmentField;
            }
            set
            {
                this.apartmentField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelLevel1 level1
        {
            get
            {
                return this.level1Field;
            }
            set
            {
                this.level1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelStreet
    {

        private string type_streetField;

        private string name_streetField;

        /// <remarks/>
        public string type_street
        {
            get
            {
                return this.type_streetField;
            }
            set
            {
                this.type_streetField = value;
            }
        }

        /// <remarks/>
        public string name_street
        {
            get
            {
                return this.name_streetField;
            }
            set
            {
                this.name_streetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelApartment
    {

        private string type_apartmentField;

        private string name_apartmentField;

        /// <remarks/>
        public string type_apartment
        {
            get
            {
                return this.type_apartmentField;
            }
            set
            {
                this.type_apartmentField = value;
            }
        }

        /// <remarks/>
        public string name_apartment
        {
            get
            {
                return this.name_apartmentField;
            }
            set
            {
                this.name_apartmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationAddressAddress_fiasDetailed_levelLevel1
    {

        private string type_level1Field;

        private string name_level1Field;

        /// <remarks/>
        public string type_level1
        {
            get
            {
                return this.type_level1Field;
            }
            set
            {
                this.type_level1Field = value;
            }
        }

        /// <remarks/>
        public string name_level1
        {
            get
            {
                return this.name_level1Field;
            }
            set
            {
                this.name_level1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordAddress_locationRel_position
    {

        private string in_boundaries_markField;

        private string ref_point_nameField;

        private string location_descriptionField;

        /// <remarks/>
        public string in_boundaries_mark
        {
            get
            {
                return this.in_boundaries_markField;
            }
            set
            {
                this.in_boundaries_markField = value;
            }
        }

        /// <remarks/>
        public string ref_point_name
        {
            get
            {
                return this.ref_point_nameField;
            }
            set
            {
                this.ref_point_nameField = value;
            }
        }

        /// <remarks/>
        public string location_description
        {
            get
            {
                return this.location_descriptionField;
            }
            set
            {
                this.location_descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordCost
    {

        private decimal valueField;

        /// <remarks/>
        public decimal value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_location
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContour[] contoursField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("contour", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContour[] contours
        {
            get
            {
                return this.contoursField;
            }
            set
            {
                this.contoursField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContour
    {

        private byte number_ppField;

        private bool number_ppFieldSpecified;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatial entity_spatialField;

        /// <remarks/>
        public byte number_pp
        {
            get
            {
                return this.number_ppField;
            }
            set
            {
                this.number_ppField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool number_ppSpecified
        {
            get
            {
                return this.number_ppFieldSpecified;
            }
            set
            {
                this.number_ppFieldSpecified = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatial entity_spatial
        {
            get
            {
                return this.entity_spatialField;
            }
            set
            {
                this.entity_spatialField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatial
    {

        private string sk_idField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatialSpatial_element[] spatials_elementsField;

        /// <remarks/>
        public string sk_id
        {
            get
            {
                return this.sk_idField;
            }
            set
            {
                this.sk_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("spatial_element", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatialSpatial_element[] spatials_elements
        {
            get
            {
                return this.spatials_elementsField;
            }
            set
            {
                this.spatials_elementsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatialSpatial_element
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatialSpatial_elementOrdinate[] ordinatesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ordinate", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatialSpatial_elementOrdinate[] ordinates
        {
            get
            {
                return this.ordinatesField;
            }
            set
            {
                this.ordinatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataLand_recordContours_locationContourEntity_spatialSpatial_elementOrdinate
    {

        private decimal xField;

        private decimal yField;

        private byte ord_nmbField;

        private string geopoint_zacrepField;

        private string num_geopointField;

        private decimal delta_geopointField;

        private bool delta_geopointFieldSpecified;

        /// <remarks/>
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public byte ord_nmb
        {
            get
            {
                return this.ord_nmbField;
            }
            set
            {
                this.ord_nmbField = value;
            }
        }

        /// <remarks/>
        public string geopoint_zacrep
        {
            get
            {
                return this.geopoint_zacrepField;
            }
            set
            {
                this.geopoint_zacrepField = value;
            }
        }

        /// <remarks/>
        public string num_geopoint
        {
            get
            {
                return this.num_geopointField;
            }
            set
            {
                this.num_geopointField = value;
            }
        }

        /// <remarks/>
        public decimal delta_geopoint
        {
            get
            {
                return this.delta_geopointField;
            }
            set
            {
                this.delta_geopointField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool delta_geopointSpecified
        {
            get
            {
                return this.delta_geopointFieldSpecified;
            }
            set
            {
                this.delta_geopointFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_record
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObject objectField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordParams paramsField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_location address_locationField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordCost costField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObject @object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordParams @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_location address_location
        {
            get
            {
                return this.address_locationField;
            }
            set
            {
                this.address_locationField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordCost cost
        {
            get
            {
                return this.costField;
            }
            set
            {
                this.costField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObject
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObjectCommon_data common_dataField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObjectCommon_data common_data
        {
            get
            {
                return this.common_dataField;
            }
            set
            {
                this.common_dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObjectCommon_data
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObjectCommon_dataType typeField;

        private string cad_numberField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObjectCommon_dataType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string cad_number
        {
            get
            {
                return this.cad_numberField;
            }
            set
            {
                this.cad_numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordObjectCommon_dataType
    {

        private uint codeField;

        private string valueField;

        /// <remarks/>
        public uint code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordParams
    {

        private decimal areaField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordParamsPurpose purposeField;

        /// <remarks/>
        public decimal area
        {
            get
            {
                return this.areaField;
            }
            set
            {
                this.areaField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordParamsPurpose purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordParamsPurpose
    {

        private ulong codeField;

        private string valueField;

        /// <remarks/>
        public ulong code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_location
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddress_type address_typeField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddress addressField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationLocation locationField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddress_type address_type
        {
            get
            {
                return this.address_typeField;
            }
            set
            {
                this.address_typeField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddress address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationLocation location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddress_type
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddress
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fias address_fiasField;

        private string readable_addressField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fias address_fias
        {
            get
            {
                return this.address_fiasField;
            }
            set
            {
                this.address_fiasField = value;
            }
        }

        /// <remarks/>
        public string readable_address
        {
            get
            {
                return this.readable_addressField;
            }
            set
            {
                this.readable_addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fias
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlement level_settlementField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_level detailed_levelField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlement level_settlement
        {
            get
            {
                return this.level_settlementField;
            }
            set
            {
                this.level_settlementField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_level detailed_level
        {
            get
            {
                return this.detailed_levelField;
            }
            set
            {
                this.detailed_levelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlement
    {

        private uint okatoField;

        private ulong kladrField;

        private uint postal_codeField;

        private bool postal_codeFieldSpecified;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementRegion regionField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict districtField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementCity cityField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementLocality localityField;

        /// <remarks/>
        public uint okato
        {
            get
            {
                return this.okatoField;
            }
            set
            {
                this.okatoField = value;
            }
        }

        /// <remarks/>
        public ulong kladr
        {
            get
            {
                return this.kladrField;
            }
            set
            {
                this.kladrField = value;
            }
        }

        /// <remarks/>
        public uint postal_code
        {
            get
            {
                return this.postal_codeField;
            }
            set
            {
                this.postal_codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool postal_codeSpecified
        {
            get
            {
                return this.postal_codeFieldSpecified;
            }
            set
            {
                this.postal_codeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementRegion region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict district
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementCity city
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementLocality locality
        {
            get
            {
                return this.localityField;
            }
            set
            {
                this.localityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementRegion
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict
    {

        private string type_districtField;

        private string name_districtField;

        /// <remarks/>
        public string type_district
        {
            get
            {
                return this.type_districtField;
            }
            set
            {
                this.type_districtField = value;
            }
        }

        /// <remarks/>
        public string name_district
        {
            get
            {
                return this.name_districtField;
            }
            set
            {
                this.name_districtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementCity
    {

        private string type_cityField;

        private string name_cityField;

        /// <remarks/>
        public string type_city
        {
            get
            {
                return this.type_cityField;
            }
            set
            {
                this.type_cityField = value;
            }
        }

        /// <remarks/>
        public string name_city
        {
            get
            {
                return this.name_cityField;
            }
            set
            {
                this.name_cityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasLevel_settlementLocality
    {

        private string type_localityField;

        private string name_localityField;

        /// <remarks/>
        public string type_locality
        {
            get
            {
                return this.type_localityField;
            }
            set
            {
                this.type_localityField = value;
            }
        }

        /// <remarks/>
        public string name_locality
        {
            get
            {
                return this.name_localityField;
            }
            set
            {
                this.name_localityField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_level
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_levelStreet streetField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_levelLevel1 level1Field;

        private string otherField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_levelStreet street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_levelLevel1 level1
        {
            get
            {
                return this.level1Field;
            }
            set
            {
                this.level1Field = value;
            }
        }

        /// <remarks/>
        public string other
        {
            get
            {
                return this.otherField;
            }
            set
            {
                this.otherField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_levelStreet
    {

        private string type_streetField;

        private string name_streetField;

        /// <remarks/>
        public string type_street
        {
            get
            {
                return this.type_streetField;
            }
            set
            {
                this.type_streetField = value;
            }
        }

        /// <remarks/>
        public string name_street
        {
            get
            {
                return this.name_streetField;
            }
            set
            {
                this.name_streetField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationAddressAddress_fiasDetailed_levelLevel1
    {

        private string type_level1Field;

        private string name_level1Field;

        /// <remarks/>
        public string type_level1
        {
            get
            {
                return this.type_level1Field;
            }
            set
            {
                this.type_level1Field = value;
            }
        }

        /// <remarks/>
        public string name_level1
        {
            get
            {
                return this.name_level1Field;
            }
            set
            {
                this.name_level1Field = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationLocation
    {

        private uint okatoField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationLocationRegion regionField;

        private string position_descriptionField;

        /// <remarks/>
        public uint okato
        {
            get
            {
                return this.okatoField;
            }
            set
            {
                this.okatoField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationLocationRegion region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public string position_description
        {
            get
            {
                return this.position_descriptionField;
            }
            set
            {
                this.position_descriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordAddress_locationLocationRegion
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataBuild_recordCost
    {

        private decimal valueField;

        /// <remarks/>
        public decimal value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_record
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObject objectField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordParams paramsField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_location address_locationField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObject @object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordParams @params
        {
            get
            {
                return this.paramsField;
            }
            set
            {
                this.paramsField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_location address_location
        {
            get
            {
                return this.address_locationField;
            }
            set
            {
                this.address_locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObject
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObjectCommon_data common_dataField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObjectCommon_data common_data
        {
            get
            {
                return this.common_dataField;
            }
            set
            {
                this.common_dataField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObjectCommon_data
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObjectCommon_dataType typeField;

        private string cad_numberField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObjectCommon_dataType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }

        /// <remarks/>
        public string cad_number
        {
            get
            {
                return this.cad_numberField;
            }
            set
            {
                this.cad_numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordObjectCommon_dataType
    {

        private uint codeField;

        private string valueField;

        /// <remarks/>
        public uint code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordParams
    {

        private string purposeField;

        /// <remarks/>
        public string purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_location
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddress addressField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddress address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddress
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fias address_fiasField;

        private string readable_addressField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fias address_fias
        {
            get
            {
                return this.address_fiasField;
            }
            set
            {
                this.address_fiasField = value;
            }
        }

        /// <remarks/>
        public string readable_address
        {
            get
            {
                return this.readable_addressField;
            }
            set
            {
                this.readable_addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fias
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlement level_settlementField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasDetailed_level detailed_levelField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlement level_settlement
        {
            get
            {
                return this.level_settlementField;
            }
            set
            {
                this.level_settlementField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasDetailed_level detailed_level
        {
            get
            {
                return this.detailed_levelField;
            }
            set
            {
                this.detailed_levelField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlement
    {

        private uint okatoField;

        private ulong kladrField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlementRegion regionField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict districtField;

        /// <remarks/>
        public uint okato
        {
            get
            {
                return this.okatoField;
            }
            set
            {
                this.okatoField = value;
            }
        }

        /// <remarks/>
        public ulong kladr
        {
            get
            {
                return this.kladrField;
            }
            set
            {
                this.kladrField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlementRegion region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict district
        {
            get
            {
                return this.districtField;
            }
            set
            {
                this.districtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlementRegion
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasLevel_settlementDistrict
    {

        private string type_districtField;

        private string name_districtField;

        /// <remarks/>
        public string type_district
        {
            get
            {
                return this.type_districtField;
            }
            set
            {
                this.type_districtField = value;
            }
        }

        /// <remarks/>
        public string name_district
        {
            get
            {
                return this.name_districtField;
            }
            set
            {
                this.name_districtField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockRecord_dataBase_dataConstruction_recordAddress_locationAddressAddress_fiasDetailed_level
    {

        private string otherField;

        /// <remarks/>
        public string other
        {
            get
            {
                return this.otherField;
            }
            set
            {
                this.otherField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_data
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatial entity_spatialField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatial entity_spatial
        {
            get
            {
                return this.entity_spatialField;
            }
            set
            {
                this.entity_spatialField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatial
    {

        private decimal sk_idField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elements spatials_elementsField;

        /// <remarks/>
        public decimal sk_id
        {
            get
            {
                return this.sk_idField;
            }
            set
            {
                this.sk_idField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elements spatials_elements
        {
            get
            {
                return this.spatials_elementsField;
            }
            set
            {
                this.spatials_elementsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elements
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elementsSpatial_element spatial_elementField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elementsSpatial_element spatial_element
        {
            get
            {
                return this.spatial_elementField;
            }
            set
            {
                this.spatial_elementField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elementsSpatial_element
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elementsSpatial_elementOrdinate[] ordinatesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ordinate", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elementsSpatial_elementOrdinate[] ordinates
        {
            get
            {
                return this.ordinatesField;
            }
            set
            {
                this.ordinatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockSpatial_dataEntity_spatialSpatials_elementsSpatial_elementOrdinate
    {

        private decimal xField;

        private decimal yField;

        /// <remarks/>
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_record
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordRecord_info record_infoField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundary b_object_municipal_boundaryField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_location b_contours_locationField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordRecord_info record_info
        {
            get
            {
                return this.record_infoField;
            }
            set
            {
                this.record_infoField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundary b_object_municipal_boundary
        {
            get
            {
                return this.b_object_municipal_boundaryField;
            }
            set
            {
                this.b_object_municipal_boundaryField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_location b_contours_location
        {
            get
            {
                return this.b_contours_locationField;
            }
            set
            {
                this.b_contours_locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordRecord_info
    {

        private System.DateTime registration_dateField;

        /// <remarks/>
        public System.DateTime registration_date
        {
            get
            {
                return this.registration_dateField;
            }
            set
            {
                this.registration_dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundary
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundaryB_object b_objectField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundaryB_object b_object
        {
            get
            {
                return this.b_objectField;
            }
            set
            {
                this.b_objectField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundaryB_object
    {

        private string reg_numb_borderField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundaryB_objectType_boundary type_boundaryField;

        /// <remarks/>
        public string reg_numb_border
        {
            get
            {
                return this.reg_numb_borderField;
            }
            set
            {
                this.reg_numb_borderField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundaryB_objectType_boundary type_boundary
        {
            get
            {
                return this.type_boundaryField;
            }
            set
            {
                this.type_boundaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_object_municipal_boundaryB_objectType_boundary
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_location
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContours contoursField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContours contours
        {
            get
            {
                return this.contoursField;
            }
            set
            {
                this.contoursField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContours
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContour contourField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContour contour
        {
            get
            {
                return this.contourField;
            }
            set
            {
                this.contourField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContour
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatial entity_spatialField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatial entity_spatial
        {
            get
            {
                return this.entity_spatialField;
            }
            set
            {
                this.entity_spatialField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatial
    {

        private string sk_idField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elements spatials_elementsField;

        /// <remarks/>
        public string sk_id
        {
            get
            {
                return this.sk_idField;
            }
            set
            {
                this.sk_idField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elements spatials_elements
        {
            get
            {
                return this.spatials_elementsField;
            }
            set
            {
                this.spatials_elementsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elements
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elementsSpatial_element spatial_elementField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elementsSpatial_element spatial_element
        {
            get
            {
                return this.spatial_elementField;
            }
            set
            {
                this.spatial_elementField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elementsSpatial_element
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elementsSpatial_elementOrdinate[] ordinatesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ordinate", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elementsSpatial_elementOrdinate[] ordinates
        {
            get
            {
                return this.ordinatesField;
            }
            set
            {
                this.ordinatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockMunicipal_boundary_recordB_contours_locationContoursContourEntity_spatialSpatials_elementsSpatial_elementOrdinate
    {

        private decimal xField;

        private decimal yField;

        private ushort ord_nmbField;

        /// <remarks/>
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public ushort ord_nmb
        {
            get
            {
                return this.ord_nmbField;
            }
            set
            {
                this.ord_nmbField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_record
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordRecord_info record_infoField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territories b_object_zones_and_territoriesField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_location b_contours_locationField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordRecord_info record_info
        {
            get
            {
                return this.record_infoField;
            }
            set
            {
                this.record_infoField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territories b_object_zones_and_territories
        {
            get
            {
                return this.b_object_zones_and_territoriesField;
            }
            set
            {
                this.b_object_zones_and_territoriesField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_location b_contours_location
        {
            get
            {
                return this.b_contours_locationField;
            }
            set
            {
                this.b_contours_locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordRecord_info
    {

        private System.DateTime registration_dateField;

        /// <remarks/>
        public System.DateTime registration_date
        {
            get
            {
                return this.registration_dateField;
            }
            set
            {
                this.registration_dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territories
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesB_object b_objectField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesType_zone type_zoneField;

        private string numberField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesB_object b_object
        {
            get
            {
                return this.b_objectField;
            }
            set
            {
                this.b_objectField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesType_zone type_zone
        {
            get
            {
                return this.type_zoneField;
            }
            set
            {
                this.type_zoneField = value;
            }
        }

        /// <remarks/>
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesB_object
    {

        private string reg_numb_borderField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesB_objectType_boundary type_boundaryField;

        /// <remarks/>
        public string reg_numb_border
        {
            get
            {
                return this.reg_numb_borderField;
            }
            set
            {
                this.reg_numb_borderField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesB_objectType_boundary type_boundary
        {
            get
            {
                return this.type_boundaryField;
            }
            set
            {
                this.type_boundaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesB_objectType_boundary
    {

        private byte codeField;

        private string valueField;

        /// <remarks/>
        public byte code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_object_zones_and_territoriesType_zone
    {

        private ulong codeField;

        private string valueField;

        /// <remarks/>
        public ulong code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_location
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContours contoursField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContours contours
        {
            get
            {
                return this.contoursField;
            }
            set
            {
                this.contoursField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContours
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContour contourField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContour contour
        {
            get
            {
                return this.contourField;
            }
            set
            {
                this.contourField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContour
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatial entity_spatialField;

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatial entity_spatial
        {
            get
            {
                return this.entity_spatialField;
            }
            set
            {
                this.entity_spatialField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatial
    {

        private string sk_idField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_element[] spatials_elementsField;

        /// <remarks/>
        public string sk_id
        {
            get
            {
                return this.sk_idField;
            }
            set
            {
                this.sk_idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("spatial_element", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_element[] spatials_elements
        {
            get
            {
                return this.spatials_elementsField;
            }
            set
            {
                this.spatials_elementsField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_element
    {

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_elementOrdinate[] ordinatesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ordinate", IsNullable = false)]
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_elementOrdinate[] ordinates
        {
            get
            {
                return this.ordinatesField;
            }
            set
            {
                this.ordinatesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_elementOrdinate
    {

        private decimal xField;

        private decimal yField;

        private ushort ord_nmbField;

        private ushort num_geopointField;

        private string geopoint_zacrepField;

        private extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_elementOrdinateGeopoint_opred geopoint_opredField;

        private decimal delta_geopointField;

        /// <remarks/>
        public decimal x
        {
            get
            {
                return this.xField;
            }
            set
            {
                this.xField = value;
            }
        }

        /// <remarks/>
        public decimal y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public ushort ord_nmb
        {
            get
            {
                return this.ord_nmbField;
            }
            set
            {
                this.ord_nmbField = value;
            }
        }

        /// <remarks/>
        public ushort num_geopoint
        {
            get
            {
                return this.num_geopointField;
            }
            set
            {
                this.num_geopointField = value;
            }
        }

        /// <remarks/>
        public string geopoint_zacrep
        {
            get
            {
                return this.geopoint_zacrepField;
            }
            set
            {
                this.geopoint_zacrepField = value;
            }
        }

        /// <remarks/>
        public extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_elementOrdinateGeopoint_opred geopoint_opred
        {
            get
            {
                return this.geopoint_opredField;
            }
            set
            {
                this.geopoint_opredField = value;
            }
        }

        /// <remarks/>
        public decimal delta_geopoint
        {
            get
            {
                return this.delta_geopointField;
            }
            set
            {
                this.delta_geopointField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class extract_cadastral_plan_territoryCadastral_blocksCadastral_blockZones_and_territories_recordB_contours_locationContoursContourEntity_spatialSpatial_elementOrdinateGeopoint_opred
    {

        private ulong codeField;

        private string valueField;

        /// <remarks/>
        public ulong code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
}
