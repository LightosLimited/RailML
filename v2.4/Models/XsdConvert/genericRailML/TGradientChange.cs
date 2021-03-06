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
    [XmlTypeAttribute("tGradientChange", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TGradientChange : TStrictOrientedElement
    {
        
        /// <summary>
        /// <para>generic type for gradient values measured in per thousand/mill</para>
        /// </summary>
        [XmlAttributeAttribute("slope")]
        public decimal Slope { get; set; }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("transitionLenght")]
        public decimal TransitionLenghtValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransitionLenght-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TransitionLenght property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TransitionLenghtValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TransitionLenght
        {
            get
            {
                if (this.TransitionLenghtValueSpecified)
                {
                    return this.TransitionLenghtValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TransitionLenghtValue = value.GetValueOrDefault();
                this.TransitionLenghtValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>generic type for radius values measured in meter</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("transitionRadius")]
        public decimal TransitionRadiusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransitionRadius-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TransitionRadius property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TransitionRadiusValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic type for radius values measured in meter</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TransitionRadius
        {
            get
            {
                if (this.TransitionRadiusValueSpecified)
                {
                    return this.TransitionRadiusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TransitionRadiusValue = value.GetValueOrDefault();
                this.TransitionRadiusValueSpecified = value.HasValue;
            }
        }
    }
}
