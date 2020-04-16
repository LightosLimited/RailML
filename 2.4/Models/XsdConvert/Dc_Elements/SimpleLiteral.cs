//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Models.XsdConvert.Dc_Elements
{
    /// <summary>
    /// <para xml:lang="en">This is the default type for all of the DC elements.
    ///            It permits text content only with optional
    ///            xml:lang attribute.
    ///            Text is allowed because mixed="true", but sub-elements
    ///            are disallowed because minOccurs="0" and maxOccurs="0" 
    ///            are on the xs:any tag.
    ///
    ///    	    This complexType allows for restriction or extension permitting
    ///            child elements.</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("SimpleLiteral", Namespace="http://purl.org/dc/elements/1.1/")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("any", Namespace="http://purl.org/dc/elements/1.1/")]
    [XmlIncludeAttribute(typeof(Contributor))]
    [XmlIncludeAttribute(typeof(Coverage))]
    [XmlIncludeAttribute(typeof(Creator))]
    [XmlIncludeAttribute(typeof(Date))]
    [XmlIncludeAttribute(typeof(Description))]
    [XmlIncludeAttribute(typeof(Format))]
    [XmlIncludeAttribute(typeof(Identifier))]
    [XmlIncludeAttribute(typeof(Language))]
    [XmlIncludeAttribute(typeof(Publisher))]
    [XmlIncludeAttribute(typeof(Relation))]
    [XmlIncludeAttribute(typeof(Rights))]
    [XmlIncludeAttribute(typeof(Source))]
    [XmlIncludeAttribute(typeof(Subject))]
    [XmlIncludeAttribute(typeof(Title))]
    [XmlIncludeAttribute(typeof(Type))]
    internal partial class SimpleLiteral
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
    }
}
