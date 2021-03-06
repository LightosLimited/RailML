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
    [XmlTypeAttribute("tLevelCrossing", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.ELevelCrossing))]
    internal partial class TLevelCrossing : TDelimitedOrientedElement, IAOcpRef
    {
        
        /// <summary>
        /// <para>length of the level crossing from railway point of view</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("length")]
        public decimal LengthValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Length-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Length property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LengthValueSpecified { get; set; }
        
        /// <summary>
        /// <para>length of the level crossing from railway point of view</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> Length
        {
            get
            {
                if (this.LengthValueSpecified)
                {
                    return this.LengthValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LengthValue = value.GetValueOrDefault();
                this.LengthValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>crossing angle between road and railway in degrees</para>
        /// <para>generic type for angle values measured in degree, allowing 0 ... +90</para>
        /// <para xml:lang="en">Minimum exclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 90.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("angle")]
        public decimal AngleValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Angle-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Angle property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AngleValueSpecified { get; set; }
        
        /// <summary>
        /// <para>crossing angle between road and railway in degrees</para>
        /// <para>generic type for angle values measured in degree, allowing 0 ... +90</para>
        /// <para xml:lang="en">Minimum exclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 90.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> Angle
        {
            get
            {
                if (this.AngleValueSpecified)
                {
                    return this.AngleValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AngleValue = value.GetValueOrDefault();
                this.AngleValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>technical protection equipment at the level crossing</para>
        /// </summary>
        [XmlAttributeAttribute("protection")]
        public string Protection { get; set; }
        
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
