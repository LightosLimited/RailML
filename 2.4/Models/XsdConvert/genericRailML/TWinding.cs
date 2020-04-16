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
    /// <para>technical data of transformer winding</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tWinding", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TWinding : IAWinding
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>type of transformer winding as descriptive name</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("assemblyName")]
        public string AssemblyName { get; set; }
        
        /// <summary>
        /// <para>nominal voltage of transformer winding (primary side) in Volts</para>
        /// <para>generic type for voltage values measured in volt</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("nominalVoltage")]
        public decimal NominalVoltageValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NominalVoltage-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NominalVoltage property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NominalVoltageValueSpecified { get; set; }
        
        /// <summary>
        /// <para>nominal voltage of transformer winding (primary side) in Volts</para>
        /// <para>generic type for voltage values measured in volt</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> NominalVoltage
        {
            get
            {
                if (this.NominalVoltageValueSpecified)
                {
                    return this.NominalVoltageValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NominalVoltageValue = value.GetValueOrDefault();
                this.NominalVoltageValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>nominal current of transformer winding (primary side) in Amps</para>
        /// <para>generic type for electric current values measured in ampere</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("nominalCurrent")]
        public decimal NominalCurrentValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NominalCurrent-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NominalCurrent property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NominalCurrentValueSpecified { get; set; }
        
        /// <summary>
        /// <para>nominal current of transformer winding (primary side) in Amps</para>
        /// <para>generic type for electric current values measured in ampere</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> NominalCurrent
        {
            get
            {
                if (this.NominalCurrentValueSpecified)
                {
                    return this.NominalCurrentValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NominalCurrentValue = value.GetValueOrDefault();
                this.NominalCurrentValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>transformation ratio of transformer winding (primary/secondary voltage)</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("transformationRatio")]
        public decimal TransformationRatioValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TransformationRatio-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TransformationRatio property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TransformationRatioValueSpecified { get; set; }
        
        /// <summary>
        /// <para>transformation ratio of transformer winding (primary/secondary voltage)</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TransformationRatio
        {
            get
            {
                if (this.TransformationRatioValueSpecified)
                {
                    return this.TransformationRatioValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TransformationRatioValue = value.GetValueOrDefault();
                this.TransformationRatioValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>resistance of primary winding of one transformer in Ohms</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("primaryResistance")]
        public decimal PrimaryResistanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PrimaryResistance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrimaryResistance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrimaryResistanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>resistance of primary winding of one transformer in Ohms</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> PrimaryResistance
        {
            get
            {
                if (this.PrimaryResistanceValueSpecified)
                {
                    return this.PrimaryResistanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrimaryResistanceValue = value.GetValueOrDefault();
                this.PrimaryResistanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>resistance of secondary winding of one transformer in Ohms transformed to primary side</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("secondaryResistance")]
        public decimal SecondaryResistanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SecondaryResistance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SecondaryResistance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SecondaryResistanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>resistance of secondary winding of one transformer in Ohms transformed to primary side</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> SecondaryResistance
        {
            get
            {
                if (this.SecondaryResistanceValueSpecified)
                {
                    return this.SecondaryResistanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SecondaryResistanceValue = value.GetValueOrDefault();
                this.SecondaryResistanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>leakage inductance of primary winding of one transformer in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("primaryLeakageInductance")]
        public decimal PrimaryLeakageInductanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PrimaryLeakageInductance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PrimaryLeakageInductance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool PrimaryLeakageInductanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>leakage inductance of primary winding of one transformer in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> PrimaryLeakageInductance
        {
            get
            {
                if (this.PrimaryLeakageInductanceValueSpecified)
                {
                    return this.PrimaryLeakageInductanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PrimaryLeakageInductanceValue = value.GetValueOrDefault();
                this.PrimaryLeakageInductanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>leakage inductance of secondary winding of one transformer in H transformed to primary side</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("secondaryLeakageInductance")]
        public decimal SecondaryLeakageInductanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SecondaryLeakageInductance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the SecondaryLeakageInductance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SecondaryLeakageInductanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>leakage inductance of secondary winding of one transformer in H transformed to primary side</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> SecondaryLeakageInductance
        {
            get
            {
                if (this.SecondaryLeakageInductanceValueSpecified)
                {
                    return this.SecondaryLeakageInductanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SecondaryLeakageInductanceValue = value.GetValueOrDefault();
                this.SecondaryLeakageInductanceValueSpecified = value.HasValue;
            }
        }
    }
}
