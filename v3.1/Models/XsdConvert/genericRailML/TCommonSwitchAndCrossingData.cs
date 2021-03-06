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
    [System.Xml.Serialization.XmlTypeAttribute("tCommonSwitchAndCrossingData", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ECrossing))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.ESwitch))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TCrossing))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TSwitch))]
    internal partial class TCommonSwitchAndCrossingData : TPlacedElement, IAOcpRef, genericRailML.IAnyAttribute
    {
        
        [System.Xml.Serialization.XmlAttributeAttribute("trackContinueCourse")]
        public string TrackContinueCourse { get; set; }
        
        /// <summary>
        /// <para>generic type for radius values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("trackContinueRadius")]
        public decimal TrackContinueRadiusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrackContinueRadius-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TrackContinueRadius property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TrackContinueRadiusValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic type for radius values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TrackContinueRadius
        {
            get
            {
                if (this.TrackContinueRadiusValueSpecified)
                {
                    return this.TrackContinueRadiusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TrackContinueRadiusValue = value.GetValueOrDefault();
                this.TrackContinueRadiusValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("normalPosition")]
        public string NormalPosition { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("model")]
        public string Model { get; set; }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("length")]
        public decimal LengthValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Length-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Length property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool LengthValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
