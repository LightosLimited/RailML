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
    [System.Xml.Serialization.XmlTypeAttribute("tAnnotationText", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TAnnotationText : genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft den Text ab oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets the text value.</para>
        /// </summary>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>natural language identification according to http://www.w3.org/TR/xml/#sec-lang-tag</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("lang", Namespace="http://www.w3.org/XML/1998/namespace")]
        public string Lang { get; set; }
    }
}
