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
    /// <summary>
    /// <para>generic curve of function y=f(x,z)</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tCurve", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(TCurrentCurve))]
    [XmlIncludeAttribute(typeof(TCurrentLimitation))]
    [XmlIncludeAttribute(typeof(TDecelerationCurve))]
    [XmlIncludeAttribute(typeof(TEfficiencyCurve))]
    [XmlIncludeAttribute(typeof(TEffortCurve))]
    [XmlIncludeAttribute(typeof(TLosses))]
    [XmlIncludeAttribute(typeof(TTrainResistance))]
    internal partial class TCurve
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>function definition vs. arbitrary variable in MathML format</para>
        /// </summary>
        [XmlAnyElementAttribute(Order=0)]
        [NotMappedAttribute()]
        public System.Xml.Linq.XElement Any { get; set; }
        
        /// <summary>
        /// <para>table of values vs. arbitrary variable representing function y=f(x,z)</para>
        /// </summary>
        [XmlElementAttribute("valueTable", Order=1)]
        public TCurveValueTable ValueTable { get; set; }
    }
}
