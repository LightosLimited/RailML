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
    [System.Xml.Serialization.XmlTypeAttribute("tPlacedElementWithLength", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EBridge))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ETunnel))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TBaseServiceSection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TBridge))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TDelimitedOrientedElementWithLength))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TOrientedElementWithLength))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TPlatformEdge))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TServiceSection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TStrictOrientedElementWithLength))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TTunnel))]
    internal partial class TPlacedElementWithLength : TBasePlacedElement
    {
        
        /// <summary>
        /// <para>Container to define disabled/enabled pieces of infrastructure with length values</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("states", Order=0)]
        public TStatesWithLength States { get; set; }
        
        /// <summary>
        /// <para>length along the track in meters</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("length")]
        public decimal LengthValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Length-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Length property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool LengthValueSpecified { get; set; }
        
        /// <summary>
        /// <para>length along the track in meters</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> Length
        {
            get
            {
                if (this.LengthValueSpecified)
                {
                    return this.LengthValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LengthValue = value.GetValueOrDefault();
                this.LengthValueSpecified = value.HasValue;
            }
        }
    }
}
