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
    [System.Xml.Serialization.XmlTypeAttribute("tBlockPartSequence", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EBlockPartSequence))]
    internal partial class TBlockPartSequence : IABlockPartSequence, genericRailML.IAnyAttribute
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TBlockPartSequence" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TBlockPartSequence" /> class.</para>
        /// </summary>
        public TBlockPartSequence()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement>();
        }
        
        /// <summary>
        /// <para>generic type for counters (e.g. order number of a vehicle in an formation), starting with '1'</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sequence")]
        public string Sequence { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private string _dayOffset = "0";
        
        /// <summary>
        /// <para>defines the day the blockPart starts if the block runs over midnight (even if it is not longer than 24 hours); first day and default value is 0</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        [System.ComponentModel.DefaultValueAttribute("0")]
        [System.Xml.Serialization.XmlAttributeAttribute("dayOffset")]
        public string DayOffset
        {
            get
            {
                return this._dayOffset;
            }
            set
            {
                this._dayOffset = value;
            }
        }
        
        /// <summary>
        /// <para>duration from the beginning of blocking of the resource until start of blockPart</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("preProcessingTime")]
        public string PreProcessingTime { get; set; }
        
        /// <summary>
        /// <para>duration from the end of blockPart until the end of blocking of the resource</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("postProcessingTime")]
        public string PostProcessingTime { get; set; }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("basicBlockRef")]
        public string BasicBlockRef { get; set; }
    }
}
