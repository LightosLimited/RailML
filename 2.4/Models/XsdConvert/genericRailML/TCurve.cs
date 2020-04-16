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
    /// <para>generic curve of function y=f(x,z)</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tCurve", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TCurrentCurve))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TCurrentLimitation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TDecelerationCurve))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TEfficiencyCurve))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TEffortCurve))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TLosses))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TTrainResistance))]
    internal partial class TCurve
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>function definition vs. arbitrary variable in MathML format</para>
        /// </summary>
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=0)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public System.Xml.Linq.XElement Any { get; set; }
        
        /// <summary>
        /// <para>table of values vs. arbitrary variable representing function y=f(x,z)</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("valueTable", Order=1)]
        public TCurveValueTable ValueTable { get; set; }
    }
}
