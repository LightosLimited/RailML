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

namespace Models.XsdConvert.genericRailML
{
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tInfrastructureVisualization", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EInfrastructureVisualization))]
    internal partial class TInfrastructureVisualization
    {
        
        /// <summary>
        /// <para>Version Number is some official release number, rather than any internal numbering from an version control system</para>
        /// <para>Allows two part or three part version numbers, 1.0 up to 99.99, or 1.0.1 up to 99.99.99</para>
        /// <para>Allows additional SVN release numbers for testing unofficial releases: 1.1r4 or 2.0r271</para>
        /// <para xml:lang="en">Pattern: [1-9][0-9]?\.([0-9]|[1-9][0-9])(\.[1-9][0-9]?)?(r[1-9][0-9]?[0-9]?)?.</para>
        /// </summary>
        [RegularExpressionAttribute("[1-9][0-9]?\\.([0-9]|[1-9][0-9])(\\.[1-9][0-9]?)?(r[1-9][0-9]?[0-9]?)?")]
        [XmlAttributeAttribute("version")]
        public string Version { get; set; }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [XmlAttributeAttribute("infrastructureRef")]
        public string InfrastructureRef { get; set; }
        
        /// <summary>
        /// <para>an XML-side constrained bi-unique identity; unique across an XML file including its outsourced components (xi:include mechanism); white spaces not allowed</para>
        /// </summary>
        [XmlAttributeAttribute("id")]
        [KeyAttribute()]
        public string Id { get; set; }
    }
}
