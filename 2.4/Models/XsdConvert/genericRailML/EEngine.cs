//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Models.XsdConvert.genericRailML
{
    /// <summary>
    /// <para>engine data about a motor car or locomotive, may be used in conjunction with 'wagon'</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("eEngine", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EEngine : genericRailML.TEngine
    {
        
        [XmlIgnoreAttribute()]
        private Collection<EPropulsion> _propulsion;
        
        /// <summary>
        /// <para>technical data about the propulsion system of a vehicle</para>
        /// </summary>
        [XmlElementAttribute("propulsion", Order=0)]
        public Collection<EPropulsion> Propulsion
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
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
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
            this._propulsion = new Collection<EPropulsion>();
            this._pantograph = new Collection<EPantograph>();
            this._energyStorage = new Collection<EStorage>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<EPantograph> _pantograph;
        
        /// <summary>
        /// <para>technical data about the installed pantographs of a vehicle</para>
        /// </summary>
        [XmlElementAttribute("pantograph", Order=1)]
        public Collection<EPantograph> Pantograph
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
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool PantographSpecified
        {
            get
            {
                return (this.Pantograph.Count != 0);
            }
        }
        
        [XmlIgnoreAttribute()]
        private Collection<EStorage> _energyStorage;
        
        /// <summary>
        /// <para>technical data about the installed energy storage devices of a vehicle</para>
        /// </summary>
        [XmlElementAttribute("energyStorage", Order=2)]
        public Collection<EStorage> EnergyStorage
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
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
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
        [XmlElementAttribute("monitoring", Order=3)]
        public EMonitoring Monitoring { get; set; }
    }
}
