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
    [System.Xml.Serialization.XmlTypeAttribute("tTrainPartSequence", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ETrainPartSequence))]
    internal partial class TTrainPartSequence : IATrainPartSequence, genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> _any;
        
        /// <summary>
        /// <para>provide an extension point for non-railML elements in foreign namespace</para>
        /// </summary>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> Any
        {
            get
            {
                return this._any;
            }
            private set
            {
                this._any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Any-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool AnySpecified
        {
            get
            {
                return (this.Any.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TTrainPartSequence" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TTrainPartSequence" /> class.</para>
        /// </summary>
        public TTrainPartSequence()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement>();
        }
        
        /// <summary>
        /// <para>generic type for counters (e.g. order number of a vehicle in an formation), starting with '1'</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sequence")]
        public string Sequence { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("pathStatus")]
        public string PathStatus { get; set; }
        
        /// <summary>
        /// <para>the category of a train which could differ (by its meaning) from a train part category</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("categoryRef")]
        public string CategoryRef { get; set; }
    }
}
