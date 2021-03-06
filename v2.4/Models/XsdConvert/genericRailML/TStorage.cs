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
    /// <para>technical data of energy storage device</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tStorage", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EStorage))]
    internal partial class TStorage : genericRailML.TElementWithIDAndName, IAStorage
    {
        
        /// <summary>
        /// <para>The maximum current in A while charging the energy storage.</para>
        /// <para>generic type for electric current values measured in ampere</para>
        /// </summary>
        [XmlAttributeAttribute("maximumCurrentCharging")]
        public decimal MaximumCurrentCharging { get; set; }
        
        /// <summary>
        /// <para>The maximum current in A while discharging the energy storage.</para>
        /// <para>generic type for electric current values measured in ampere</para>
        /// </summary>
        [XmlAttributeAttribute("maximumCurrentDischarging")]
        public decimal MaximumCurrentDischarging { get; set; }
        
        /// <summary>
        /// <para>The maximum power in W while charging the energy storage.</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [XmlAttributeAttribute("maximumPowerCharging")]
        public decimal MaximumPowerCharging { get; set; }
        
        /// <summary>
        /// <para>The maximum power in W while discharging the energy storage.</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [XmlAttributeAttribute("maximumPowerDischarging")]
        public decimal MaximumPowerDischarging { get; set; }
        
        /// <summary>
        /// <para>The maximum energy in kWh charging to the energy storage.</para>
        /// <para>generic type for energy values measured in kilowatt*hour</para>
        /// </summary>
        [XmlAttributeAttribute("maximumChargingEnergy")]
        public decimal MaximumChargingEnergy { get; set; }
        
        /// <summary>
        /// <para>The efficiency while charging the energy storage.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0", "1")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("chargingEfficiency")]
        public decimal ChargingEfficiencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ChargingEfficiency-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ChargingEfficiency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ChargingEfficiencyValueSpecified { get; set; }
        
        /// <summary>
        /// <para>The efficiency while charging the energy storage.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> ChargingEfficiency
        {
            get
            {
                if (this.ChargingEfficiencyValueSpecified)
                {
                    return this.ChargingEfficiencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ChargingEfficiencyValue = value.GetValueOrDefault();
                this.ChargingEfficiencyValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>The efficiency while discharging the energy storage.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0", "1")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("dischargingEfficiency")]
        public decimal DischargingEfficiencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DischargingEfficiency-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DischargingEfficiency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DischargingEfficiencyValueSpecified { get; set; }
        
        /// <summary>
        /// <para>The efficiency while discharging the energy storage.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> DischargingEfficiency
        {
            get
            {
                if (this.DischargingEfficiencyValueSpecified)
                {
                    return this.DischargingEfficiencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DischargingEfficiencyValue = value.GetValueOrDefault();
                this.DischargingEfficiencyValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>The mean efficiency of the energy storage.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0", "1")]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("meanStorageEfficiency")]
        public decimal MeanStorageEfficiencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeanStorageEfficiency-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MeanStorageEfficiency property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MeanStorageEfficiencyValueSpecified { get; set; }
        
        /// <summary>
        /// <para>The mean efficiency of the energy storage.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> MeanStorageEfficiency
        {
            get
            {
                if (this.MeanStorageEfficiencyValueSpecified)
                {
                    return this.MeanStorageEfficiencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MeanStorageEfficiencyValue = value.GetValueOrDefault();
                this.MeanStorageEfficiencyValueSpecified = value.HasValue;
            }
        }
    }
}
