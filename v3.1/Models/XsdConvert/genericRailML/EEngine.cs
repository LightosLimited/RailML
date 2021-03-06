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
    
    
    /// <summary>
    /// <para>engine data about a motor car or locomotive, may be used in conjunction with 'wagon'</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("eEngine", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EEngine : genericRailML.TEngine
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<EPropulsion> _propulsion;
        
        /// <summary>
        /// <para>technical data about the propulsion system of a vehicle</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("propulsion", Order=0)]
        public System.Collections.ObjectModel.Collection<EPropulsion> Propulsion
        {
            get
            {
                return this._propulsion;
            }
            private set
            {
                this._propulsion = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Propulsion-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Propulsion collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool PropulsionSpecified
        {
            get
            {
                return (this.Propulsion.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EEngine" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EEngine" /> class.</para>
        /// </summary>
        public EEngine()
        {
            this._propulsion = new System.Collections.ObjectModel.Collection<EPropulsion>();
            this._pantograph = new System.Collections.ObjectModel.Collection<EPantograph>();
            this._energyStorage = new System.Collections.ObjectModel.Collection<EStorage>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<EPantograph> _pantograph;
        
        /// <summary>
        /// <para>technical data about the installed pantographs of a vehicle</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("pantograph", Order=1)]
        public System.Collections.ObjectModel.Collection<EPantograph> Pantograph
        {
            get
            {
                return this._pantograph;
            }
            private set
            {
                this._pantograph = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Pantograph-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Pantograph collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool PantographSpecified
        {
            get
            {
                return (this.Pantograph.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<EStorage> _energyStorage;
        
        /// <summary>
        /// <para>technical data about the installed energy storage devices of a vehicle</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("energyStorage", Order=2)]
        public System.Collections.ObjectModel.Collection<EStorage> EnergyStorage
        {
            get
            {
                return this._energyStorage;
            }
            private set
            {
                this._energyStorage = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EnergyStorage-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the EnergyStorage collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool EnergyStorageSpecified
        {
            get
            {
                return (this.EnergyStorage.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>types of signalling systems fitted to the vehicle</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("monitoring", Order=3)]
        public EMonitoring Monitoring { get; set; }
    }
}
