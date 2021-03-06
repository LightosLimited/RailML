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
    /// <para>technical data of traction motor</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tTractionMotor", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.ETractionMotor))]
    internal partial class TTractionMotor : IAAssemblyNameNumber, IATractionMotor
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>number of assemblies per vehicle/unit</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        [XmlAttributeAttribute("count")]
        public string Count { get; set; }
        
        /// <summary>
        /// <para>type of assembly as descriptive name</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("assemblyName")]
        public string AssemblyName { get; set; }
        
        /// <summary>
        /// <para>rated power consumption of one traction motor in Watt</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("nominalPower")]
        public decimal NominalPowerValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NominalPower-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NominalPower property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NominalPowerValueSpecified { get; set; }
        
        /// <summary>
        /// <para>rated power consumption of one traction motor in Watt</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> NominalPower
        {
            get
            {
                if (this.NominalPowerValueSpecified)
                {
                    return this.NominalPowerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NominalPowerValue = value.GetValueOrDefault();
                this.NominalPowerValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>rated voltage of traction motor in Volts</para>
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
        /// <para>rated voltage of traction motor in Volts</para>
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
        /// <para>rated current of one traction motor in Amps</para>
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
        /// <para>rated current of one traction motor in Amps</para>
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
        /// <para>rated frequency of traction motor windings in Hz</para>
        /// <para>generic type for frequency values measured in hertz</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("nominalFrequency")]
        public decimal NominalFrequencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NominalFrequency-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NominalFrequency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NominalFrequencyValueSpecified { get; set; }
        
        /// <summary>
        /// <para>rated frequency of traction motor windings in Hz</para>
        /// <para>generic type for frequency values measured in hertz</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> NominalFrequency
        {
            get
            {
                if (this.NominalFrequencyValueSpecified)
                {
                    return this.NominalFrequencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NominalFrequencyValue = value.GetValueOrDefault();
                this.NominalFrequencyValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>nominal flux of one traction motor in Volt*sec</para>
        /// <para>generic type for electric flux values measured in volt*second</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("nominalFlux")]
        public decimal NominalFluxValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NominalFlux-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NominalFlux property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NominalFluxValueSpecified { get; set; }
        
        /// <summary>
        /// <para>nominal flux of one traction motor in Volt*sec</para>
        /// <para>generic type for electric flux values measured in volt*second</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> NominalFlux
        {
            get
            {
                if (this.NominalFluxValueSpecified)
                {
                    return this.NominalFluxValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NominalFluxValue = value.GetValueOrDefault();
                this.NominalFluxValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>nominal phase angle phi of traction motor in the range -180..+180</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "-180", "180")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("nominalPhi")]
        public decimal NominalPhiValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NominalPhi-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NominalPhi property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NominalPhiValueSpecified { get; set; }
        
        /// <summary>
        /// <para>nominal phase angle phi of traction motor in the range -180..+180</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> NominalPhi
        {
            get
            {
                if (this.NominalPhiValueSpecified)
                {
                    return this.NominalPhiValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NominalPhiValue = value.GetValueOrDefault();
                this.NominalPhiValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>number of pole pairs of one traction motor</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        [XmlAttributeAttribute("numberPolePairs")]
        public string NumberPolePairs { get; set; }
        
        /// <summary>
        /// <para>resistance of stator winding of one traction motor in Ohms</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("statorResistance")]
        public decimal StatorResistanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StatorResistance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StatorResistance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StatorResistanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>resistance of stator winding of one traction motor in Ohms</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> StatorResistance
        {
            get
            {
                if (this.StatorResistanceValueSpecified)
                {
                    return this.StatorResistanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StatorResistanceValue = value.GetValueOrDefault();
                this.StatorResistanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>resistance of rotor winding of one traction motor in Ohms</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("rotorResistance")]
        public decimal RotorResistanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RotorResistance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RotorResistance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RotorResistanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>resistance of rotor winding of one traction motor in Ohms</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> RotorResistance
        {
            get
            {
                if (this.RotorResistanceValueSpecified)
                {
                    return this.RotorResistanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RotorResistanceValue = value.GetValueOrDefault();
                this.RotorResistanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>resistance of iron core of one traction motor in Ohms (open-circuit core loss)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("ferrumResistance")]
        public decimal FerrumResistanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FerrumResistance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FerrumResistance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FerrumResistanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>resistance of iron core of one traction motor in Ohms (open-circuit core loss)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> FerrumResistance
        {
            get
            {
                if (this.FerrumResistanceValueSpecified)
                {
                    return this.FerrumResistanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FerrumResistanceValue = value.GetValueOrDefault();
                this.FerrumResistanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>additional resistance of one traction motor in Ohms due to non-sinusoid currents (stray loss)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("additionalResistance")]
        public decimal AdditionalResistanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalResistance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AdditionalResistance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AdditionalResistanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>additional resistance of one traction motor in Ohms due to non-sinusoid currents (stray loss)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> AdditionalResistance
        {
            get
            {
                if (this.AdditionalResistanceValueSpecified)
                {
                    return this.AdditionalResistanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AdditionalResistanceValue = value.GetValueOrDefault();
                this.AdditionalResistanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>main inductance of one traction motor in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("mainInductance")]
        public decimal MainInductanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MainInductance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MainInductance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MainInductanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>main inductance of one traction motor in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> MainInductance
        {
            get
            {
                if (this.MainInductanceValueSpecified)
                {
                    return this.MainInductanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MainInductanceValue = value.GetValueOrDefault();
                this.MainInductanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>leakage inductance of stator winding of one traction motor in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("statorLeakageInductance")]
        public decimal StatorLeakageInductanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StatorLeakageInductance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StatorLeakageInductance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StatorLeakageInductanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>leakage inductance of stator winding of one traction motor in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> StatorLeakageInductance
        {
            get
            {
                if (this.StatorLeakageInductanceValueSpecified)
                {
                    return this.StatorLeakageInductanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StatorLeakageInductanceValue = value.GetValueOrDefault();
                this.StatorLeakageInductanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>leakage inductance of rotor winding of one traction motor in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("rotorLeakageInductance")]
        public decimal RotorLeakageInductanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RotorLeakageInductance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RotorLeakageInductance property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RotorLeakageInductanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>leakage inductance of rotor winding of one traction motor in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> RotorLeakageInductance
        {
            get
            {
                if (this.RotorLeakageInductanceValueSpecified)
                {
                    return this.RotorLeakageInductanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RotorLeakageInductanceValue = value.GetValueOrDefault();
                this.RotorLeakageInductanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>nominal number of revolutions in revolutions per minute (rpm)</para>
        /// <para>generic type for rotational frequency values measured in revolutions per minute</para>
        /// </summary>
        [XmlAttributeAttribute("nominalRevolutions")]
        public string NominalRevolutions { get; set; }
        
        /// <summary>
        /// <para>The traction motor mean efficiency in the range 0..1.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0", "1")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("meanEfficiency")]
        public decimal MeanEfficiencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeanEfficiency-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MeanEfficiency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MeanEfficiencyValueSpecified { get; set; }
        
        /// <summary>
        /// <para>The traction motor mean efficiency in the range 0..1.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> MeanEfficiency
        {
            get
            {
                if (this.MeanEfficiencyValueSpecified)
                {
                    return this.MeanEfficiencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MeanEfficiencyValue = value.GetValueOrDefault();
                this.MeanEfficiencyValueSpecified = value.HasValue;
            }
        }
    }
}
