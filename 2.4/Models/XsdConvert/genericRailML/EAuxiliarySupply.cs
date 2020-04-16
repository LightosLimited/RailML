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
    [System.Xml.Serialization.XmlTypeAttribute("eAuxiliarySupply", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EAuxiliarySupply : genericRailML.TAuxiliarySupply
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TAuxiliarySupplySystem> _dedicatedSupplySystem;
        
        /// <summary>
        /// <para>list of available supply systems for auxiliaries</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("dedicatedSupplySystem", Order=0)]
        public System.Collections.ObjectModel.Collection<genericRailML.TAuxiliarySupplySystem> DedicatedSupplySystem
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EAuxiliarySupply" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EAuxiliarySupply" /> class.</para>
        /// </summary>
        public EAuxiliarySupply()
        {
            this._dedicatedSupplySystem = new System.Collections.ObjectModel.Collection<genericRailML.TAuxiliarySupplySystem>();
        }
    }
}
