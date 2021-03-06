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
    /// <para>data about the car body of a vehicle and its payload</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("eWagon", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EWagon : genericRailML.TWagon
    {
        
        /// <summary>
        /// <para>data for passenger cars</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("passenger", Order=0)]
        public EPassenger Passenger { get; set; }
        
        /// <summary>
        /// <para>data for freight cars</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("goods", Order=1)]
        public EGoods Goods { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TElectrificationSystem> _auxiliarySupplySystem;
        
        /// <summary>
        /// <para>installed supply systems for auxiliaries in the vehicle</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("auxiliarySupplySystem", Order=2)]
        public System.Collections.ObjectModel.Collection<genericRailML.TElectrificationSystem> AuxiliarySupplySystem
        {
            get
            {
                return this._auxiliarySupplySystem;
            }
            private set
            {
                this._auxiliarySupplySystem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AuxiliarySupplySystem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AuxiliarySupplySystem collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool AuxiliarySupplySystemSpecified
        {
            get
            {
                return (this.AuxiliarySupplySystem.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EWagon" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EWagon" /> class.</para>
        /// </summary>
        public EWagon()
        {
            this._auxiliarySupplySystem = new System.Collections.ObjectModel.Collection<genericRailML.TElectrificationSystem>();
            this._driversCab = new System.Collections.ObjectModel.Collection<genericRailML.TDriversCabType>();
            this._trainClearanceGauge = new System.Collections.ObjectModel.Collection<genericRailML.TClearanceGaugeType>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TDriversCabType> _driversCab;
        
        /// <summary>
        /// <para>data about each drivers cab of the vehicle</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("driversCab", Order=3)]
        public System.Collections.ObjectModel.Collection<genericRailML.TDriversCabType> DriversCab
        {
            get
            {
                return this._driversCab;
            }
            private set
            {
                this._driversCab = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DriversCab-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DriversCab collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DriversCabSpecified
        {
            get
            {
                return (this.DriversCab.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>data about rack traction equipment of the vehicle used for braking only</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("rackTraction", Order=4)]
        public genericRailML.TRackTractionType RackTraction { get; set; }
        
        /// <summary>
        /// <para>data for couplers between wagons</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("couplers", Order=5)]
        public ECouplers Couplers { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TClearanceGaugeType> _trainClearanceGauge;
        
        /// <summary>
        /// <para>data about all compatible clearance gauges of the vehicle</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainClearanceGauge", Order=6)]
        public System.Collections.ObjectModel.Collection<genericRailML.TClearanceGaugeType> TrainClearanceGauge
        {
            get
            {
                return this._trainClearanceGauge;
            }
            private set
            {
                this._trainClearanceGauge = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainClearanceGauge-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TrainClearanceGauge collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool TrainClearanceGaugeSpecified
        {
            get
            {
                return (this.TrainClearanceGauge.Count != 0);
            }
        }
    }
}
