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
    [System.Xml.Serialization.XmlTypeAttribute("tTrack", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ETrack))]
    internal partial class TTrack : genericRailML.TElementWithIDAndName
    {
        
        /// <summary>
        /// <para>Container to define disabled/enabled pieces of a track</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("states", Order=0)]
        public TStatesWithLength States { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }
        
        /// <summary>
        /// <para>main driving direction on the track</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("mainDir")]
        public genericRailML.TExtendedDirection MainDirValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MainDir-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MainDir property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MainDirValueSpecified { get; set; }
        
        /// <summary>
        /// <para>main driving direction on the track</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<genericRailML.TExtendedDirection> MainDir
        {
            get
            {
                if (this.MainDirValueSpecified)
                {
                    return this.MainDirValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MainDirValue = value.GetValueOrDefault();
                this.MainDirValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>DEPRECATED: use sub-element infraAttrGroupRef instead.</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("infraAttrGroupRef")]
        public string InfraAttrGroupRef { get; set; }
    }
}
