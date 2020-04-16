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
    [XmlTypeAttribute("tTrackCircuitBorder", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TTrackCircuitBorder : TDelimitedOrientedElement, IAOcpRef
    {
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("insulatedRail")]
        public TInsulatedRailSide InsulatedRailValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die InsulatedRail-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the InsulatedRail property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool InsulatedRailValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<TInsulatedRailSide> InsulatedRail
        {
            get
            {
                if (this.InsulatedRailValueSpecified)
                {
                    return this.InsulatedRailValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.InsulatedRailValue = value.GetValueOrDefault();
                this.InsulatedRailValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>reference on ocp element, e.g. station</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [XmlAttributeAttribute("ocpStationRef")]
        public string OcpStationRef { get; set; }
        
        /// <summary>
        /// <para>reference on controller element, e.g. interlocking</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [XmlAttributeAttribute("controllerRef")]
        public string ControllerRef { get; set; }
    }
}
