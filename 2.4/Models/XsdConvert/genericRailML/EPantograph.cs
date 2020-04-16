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
    /// <para>technical data about the installed pantographs of a vehicle</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("ePantograph", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EPantograph : genericRailML.TPantograph
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TElectrificationSystem> _dedicatedSupplySystem;
        
        /// <summary>
        /// <para>technical data of the supply system the pantograph is used for</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("dedicatedSupplySystem", Order=0)]
        public System.Collections.ObjectModel.Collection<genericRailML.TElectrificationSystem> DedicatedSupplySystem
        {
            get
            {
                return this._dedicatedSupplySystem;
            }
            private set
            {
                this._dedicatedSupplySystem = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DedicatedSupplySystem-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the DedicatedSupplySystem collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool DedicatedSupplySystemSpecified
        {
            get
            {
                return (this.DedicatedSupplySystem.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EPantograph" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EPantograph" /> class.</para>
        /// </summary>
        public EPantograph()
        {
            this._dedicatedSupplySystem = new System.Collections.ObjectModel.Collection<genericRailML.TElectrificationSystem>();
        }
    }
}
