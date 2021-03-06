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
    /// <para>technical data of diesel engine</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tDieselEngine", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TDieselEngine : IAAssemblyNameNumber, IADieselEngine
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
        /// <para>nominal power per diesel engine in Watt</para>
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
        /// <para>nominal power per diesel engine in Watt</para>
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
        /// <para>nominal power per diesel engine in Watt leftover for auxiliary supply</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("availableAuxiliaryPower")]
        public decimal AvailableAuxiliaryPowerValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AvailableAuxiliaryPower-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AvailableAuxiliaryPower property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AvailableAuxiliaryPowerValueSpecified { get; set; }
        
        /// <summary>
        /// <para>nominal power per diesel engine in Watt leftover for auxiliary supply</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> AvailableAuxiliaryPower
        {
            get
            {
                if (this.AvailableAuxiliaryPowerValueSpecified)
                {
                    return this.AvailableAuxiliaryPowerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AvailableAuxiliaryPowerValue = value.GetValueOrDefault();
                this.AvailableAuxiliaryPowerValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>fuel capacity of the entire diesel tank in liters</para>
        /// <para>generic type for volume values measured in litre</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("fuelCapacity")]
        public decimal FuelCapacityValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FuelCapacity-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FuelCapacity property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FuelCapacityValueSpecified { get; set; }
        
        /// <summary>
        /// <para>fuel capacity of the entire diesel tank in liters</para>
        /// <para>generic type for volume values measured in litre</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> FuelCapacity
        {
            get
            {
                if (this.FuelCapacityValueSpecified)
                {
                    return this.FuelCapacityValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FuelCapacityValue = value.GetValueOrDefault();
                this.FuelCapacityValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>average efficiency of the diesel engine in the range 0..1</para>
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
        /// <para>average efficiency of the diesel engine in the range 0..1</para>
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
