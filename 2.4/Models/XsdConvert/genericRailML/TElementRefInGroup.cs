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
    /// <para>generic type for inheritance in serialized reference elements</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tElementRefInGroup", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TBaliseRefInGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TOcpRefInGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TSignalRefInGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.TTrackRefInGroup))]
    internal partial class TElementRefInGroup : TElementWithReference
    {
        
        /// <summary>
        /// <para>generic type for counters (e.g. order number of a vehicle in an formation), starting with '1'</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sequence")]
        public string Sequence { get; set; }
    }
}
