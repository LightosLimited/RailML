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
    [System.Xml.Serialization.XmlTypeAttribute("ePassengerFacility", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EPassenger))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TPassenger))]
    internal partial class EPassengerFacility
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TPlaces> _places;
        
        /// <summary>
        /// <para>list of place capacity of the vehicle divided by particular categories</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("places", Order=0)]
        public System.Collections.ObjectModel.Collection<TPlaces> Places
        {
            get
            {
                return this._places;
            }
            private set
            {
                this._places = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Places-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Places collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool PlacesSpecified
        {
            get
            {
                return (this.Places.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EPassengerFacility" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EPassengerFacility" /> class.</para>
        /// </summary>
        public EPassengerFacility()
        {
            this._places = new System.Collections.ObjectModel.Collection<TPlaces>();
            this._service = new System.Collections.ObjectModel.Collection<TService>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TService> _service;
        
        /// <summary>
        /// <para>description of any additional service provided per vehicle</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("service", Order=1)]
        public System.Collections.ObjectModel.Collection<TService> Service
        {
            get
            {
                return this._service;
            }
            private set
            {
                this._service = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Service-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Service collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ServiceSpecified
        {
            get
            {
                return (this.Service.Count != 0);
            }
        }
    }
}
