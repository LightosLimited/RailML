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
    /// <para>generic base type, used for inheritance of railML types deploying references</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tElementWithReference", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ELineVis))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EOcpVis))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EOperatingPeriodRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ETrackElementVis))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ETrackVis))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TAnnotationRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TBaliseRefInGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TBlockPartRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TElementRefInGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TOcpRefInGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TOperatingPeriodRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TPlatformEdgeRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TServiceSectionRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TSignalRefInGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TSpeedProfileRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TTrackRef))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TTrackRefInGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TTrainPartRef))]
    internal partial class TElementWithReference : IAnyAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>reference is required because it's the purpose of the element</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ref")]
        public string Ref { get; set; }
    }
}
