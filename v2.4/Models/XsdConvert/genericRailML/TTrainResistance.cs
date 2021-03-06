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
    /// <para>mechanical train resistance vs. speed</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tTrainResistance", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TTrainResistance : TCurve, IAResistanceFormula
    {
        
        /// <summary>
        /// <para>factor for increasing air resistance when running through tunnel</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("tunnelFactor")]
        public decimal TunnelFactorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TunnelFactor-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TunnelFactor property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TunnelFactorValueSpecified { get; set; }
        
        /// <summary>
        /// <para>factor for increasing air resistance when running through tunnel</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TunnelFactor
        {
            get
            {
                if (this.TunnelFactorValueSpecified)
                {
                    return this.TunnelFactorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TunnelFactorValue = value.GetValueOrDefault();
                this.TunnelFactorValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>coefficent used for calculation of train resistance according formula of Strahl/Sauthoff</para>
        /// <para>generic type for coefficent values measured in newton</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("strahlFactor")]
        public decimal StrahlFactorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StrahlFactor-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StrahlFactor property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StrahlFactorValueSpecified { get; set; }
        
        /// <summary>
        /// <para>coefficent used for calculation of train resistance according formula of Strahl/Sauthoff</para>
        /// <para>generic type for coefficent values measured in newton</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> StrahlFactor
        {
            get
            {
                if (this.StrahlFactorValueSpecified)
                {
                    return this.StrahlFactorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StrahlFactorValue = value.GetValueOrDefault();
                this.StrahlFactorValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>flag, whether the coefficents of Davies formula are to be considered mass dependent</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("daviesMassDependent")]
        public bool DaviesMassDependentValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DaviesMassDependent-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DaviesMassDependent property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DaviesMassDependentValueSpecified { get; set; }
        
        /// <summary>
        /// <para>flag, whether the coefficents of Davies formula are to be considered mass dependent</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> DaviesMassDependent
        {
            get
            {
                if (this.DaviesMassDependentValueSpecified)
                {
                    return this.DaviesMassDependentValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DaviesMassDependentValue = value.GetValueOrDefault();
                this.DaviesMassDependentValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>constant coefficent A used for calculation of train resistance according formula of Davies</para>
        /// <para>generic type for coefficent values measured in newton</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("daviesFactorA")]
        public decimal DaviesFactorAValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DaviesFactorA-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DaviesFactorA property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DaviesFactorAValueSpecified { get; set; }
        
        /// <summary>
        /// <para>constant coefficent A used for calculation of train resistance according formula of Davies</para>
        /// <para>generic type for coefficent values measured in newton</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> DaviesFactorA
        {
            get
            {
                if (this.DaviesFactorAValueSpecified)
                {
                    return this.DaviesFactorAValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DaviesFactorAValue = value.GetValueOrDefault();
                this.DaviesFactorAValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>speed dependent coefficent B used for calculation of train resistance according formula of Davies</para>
        /// <para>generic type for coefficent values measured in newton</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("daviesFactorB")]
        public decimal DaviesFactorBValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DaviesFactorB-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DaviesFactorB property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DaviesFactorBValueSpecified { get; set; }
        
        /// <summary>
        /// <para>speed dependent coefficent B used for calculation of train resistance according formula of Davies</para>
        /// <para>generic type for coefficent values measured in newton</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> DaviesFactorB
        {
            get
            {
                if (this.DaviesFactorBValueSpecified)
                {
                    return this.DaviesFactorBValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DaviesFactorBValue = value.GetValueOrDefault();
                this.DaviesFactorBValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>square speed dependent coefficent C used for calculation of train resistance according formula of Davies</para>
        /// <para>generic type for coefficent values measured in newton</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("daviesFactorC")]
        public decimal DaviesFactorCValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DaviesFactorC-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DaviesFactorC property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DaviesFactorCValueSpecified { get; set; }
        
        /// <summary>
        /// <para>square speed dependent coefficent C used for calculation of train resistance according formula of Davies</para>
        /// <para>generic type for coefficent values measured in newton</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> DaviesFactorC
        {
            get
            {
                if (this.DaviesFactorCValueSpecified)
                {
                    return this.DaviesFactorCValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DaviesFactorCValue = value.GetValueOrDefault();
                this.DaviesFactorCValueSpecified = value.HasValue;
            }
        }
    }
}
