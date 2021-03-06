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
    [System.Xml.Serialization.XmlTypeAttribute("eCouplers", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class ECouplers
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<EMechanicalCoupler> _mechanicalCoupler;
        
        /// <summary>
        /// <para>container for available mechanical couplers between wagons</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("mechanicalCoupler", Order=0)]
        public System.Collections.ObjectModel.Collection<EMechanicalCoupler> MechanicalCoupler
        {
            get
            {
                return this._mechanicalCoupler;
            }
            private set
            {
                this._mechanicalCoupler = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MechanicalCoupler-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the MechanicalCoupler collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool MechanicalCouplerSpecified
        {
            get
            {
                return (this.MechanicalCoupler.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ECouplers" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ECouplers" /> class.</para>
        /// </summary>
        public ECouplers()
        {
            this._mechanicalCoupler = new System.Collections.ObjectModel.Collection<EMechanicalCoupler>();
            this._pneumaticCoupler = new System.Collections.ObjectModel.Collection<EPneumaticCoupler>();
            this._electricalCoupler = new System.Collections.ObjectModel.Collection<EElectricalCoupler>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<EPneumaticCoupler> _pneumaticCoupler;
        
        /// <summary>
        /// <para>container for available pneumatic couplers between wagons</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("pneumaticCoupler", Order=1)]
        public System.Collections.ObjectModel.Collection<EPneumaticCoupler> PneumaticCoupler
        {
            get
            {
                return this._pneumaticCoupler;
            }
            private set
            {
                this._pneumaticCoupler = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PneumaticCoupler-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the PneumaticCoupler collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool PneumaticCouplerSpecified
        {
            get
            {
                return (this.PneumaticCoupler.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<EElectricalCoupler> _electricalCoupler;
        
        /// <summary>
        /// <para>container for available electrical couplers between wagons</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("electricalCoupler", Order=2)]
        public System.Collections.ObjectModel.Collection<EElectricalCoupler> ElectricalCoupler
        {
            get
            {
                return this._electricalCoupler;
            }
            private set
            {
                this._electricalCoupler = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ElectricalCoupler-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ElectricalCoupler collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ElectricalCouplerSpecified
        {
            get
            {
                return (this.ElectricalCoupler.Count != 0);
            }
        }
    }
}
