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
    [System.Xml.Serialization.XmlTypeAttribute("tBaliseGroup", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TBaliseGroup : genericRailML.TElementWithIDAndName
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TBaliseRefInGroup> _baliseRef;
        
        [System.Xml.Serialization.XmlElementAttribute("baliseRef", Order=0)]
        public System.Collections.ObjectModel.Collection<TBaliseRefInGroup> BaliseRef
        {
            get
            {
                return this._baliseRef;
            }
            private set
            {
                this._baliseRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TBaliseGroup" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TBaliseGroup" /> class.</para>
        /// </summary>
        public TBaliseGroup()
        {
            this._baliseRef = new System.Collections.ObjectModel.Collection<TBaliseRefInGroup>();
        }
        
        /// <summary>
        /// <para>functional type of the balise group</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }
    }
}
