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
    [System.Xml.Serialization.XmlTypeAttribute("tLocallyControlledArea", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ELocallyControlledArea))]
    internal partial class TLocallyControlledArea : genericRailML.TElementWithIDAndName, IAOcpRef
    {
        
        /// <summary>
        /// <para>Container to define disabled/enabled locally controlled areas</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("states", Order=0)]
        public TStates States { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED: use attribute 'ocpStationRef' or 'controllerRef' instead</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ocpRef")]
        public string OcpRef { get; set; }
        
        /// <summary>
        /// <para>reference on ocp element, e.g. station</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ocpStationRef")]
        public string OcpStationRef { get; set; }
        
        /// <summary>
        /// <para>reference on controller element, e.g. interlocking</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("controllerRef")]
        public string ControllerRef { get; set; }
    }
}
