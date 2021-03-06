//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace Models.XsdConvert.genericRailML
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("eOcp", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EOcp : genericRailML.TOperationControlPoint
    {
        
        [System.Xml.Serialization.XmlElementAttribute("propOperational", Order=0)]
        public EOcpPropOperational PropOperational { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("propService", Order=1)]
        public genericRailML.TOcpPropService PropService { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("propEquipment", Order=2)]
        public EOcpPropEquipment PropEquipment { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("propOther", Order=3)]
        public EOcpPropOther PropOther { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED. Use register entry "PrimaryLocationCode" instead.</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("tsi", Order=4)]
        public genericRailML.TOcpTsi Tsi { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("area", Order=5)]
        public genericRailML.TOcpArea Area { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("geoCoord", Order=6)]
        public genericRailML.TGeoCoord GeoCoord { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TDesignator> _designator;
        
        [System.Xml.Serialization.XmlElementAttribute("designator", Order=7)]
        public System.Collections.ObjectModel.Collection<genericRailML.TDesignator> Designator
        {
            get
            {
                return this._designator;
            }
            private set
            {
                this._designator = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Designator-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Designator collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DesignatorSpecified
        {
            get
            {
                return (this.Designator.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EOcp" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EOcp" /> class.</para>
        /// </summary>
        public EOcp()
        {
            this._designator = new System.Collections.ObjectModel.Collection<genericRailML.TDesignator>();
        }
    }
}
