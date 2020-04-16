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
    [System.Xml.Serialization.XmlTypeAttribute("tOcpPropOther", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EOcpPropOther))]
    internal partial class TOcpPropOther
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _frontier = false;
        
        /// <summary>
        /// <para>DEPRECATED, because usage unclear.</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("frontier")]
        public bool Frontier
        {
            get
            {
                return this._frontier;
            }
            set
            {
                this._frontier = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _chargeFrontier = false;
        
        /// <summary>
        /// <para>DEPRECATED, because usage unclear.</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("chargeFrontier")]
        public bool ChargeFrontier
        {
            get
            {
                return this._chargeFrontier;
            }
            set
            {
                this._chargeFrontier = value;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _status = "operational";
        
        /// <summary>
        /// <para>DEPRECATED! Please use new optional child element "states" instead; defines the status of the OCP in terms of availability for operation</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute("operational")]
        [System.Xml.Serialization.XmlAttributeAttribute("status")]
        public string Status
        {
            get
            {
                return this._status;
            }
            set
            {
                this._status = value;
            }
        }
    }
}
