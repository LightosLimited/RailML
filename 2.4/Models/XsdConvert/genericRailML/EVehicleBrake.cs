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
    [XmlTypeAttribute("eVehicleBrake", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EVehicleBrake : genericRailML.TBasicBrakeType, IAVehicleBrake
    {
        
        /// <summary>
        /// <para>for wagons with "full" / "empty" switch</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("loadSwitch")]
        public genericRailML.TLoadSwitch LoadSwitchValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LoadSwitch-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoadSwitch property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool LoadSwitchValueSpecified { get; set; }
        
        /// <summary>
        /// <para>for wagons with "full" / "empty" switch</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<genericRailML.TLoadSwitch> LoadSwitch
        {
            get
            {
                if (this.LoadSwitchValueSpecified)
                {
                    return this.LoadSwitchValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoadSwitchValue = value.GetValueOrDefault();
                this.LoadSwitchValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>automatically regulated brake percentages depending on actual load of vehicle</para>
        /// <para>Brake percentage as value of braking performance in relation to vehicle weight</para>
        /// <para xml:lang="en">Maximum inclusive value: 225.</para>
        /// <para xml:lang="en">Minimum inclusive value: 6.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "6", "225")]
        [XmlAttributeAttribute("autoBrakePercentage")]
        public string AutoBrakePercentage { get; set; }
        
        /// <summary>
        /// <para>maximum brake mass of automatic brake</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("maxAutoBrakeMass")]
        public decimal MaxAutoBrakeMassValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MaxAutoBrakeMass-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxAutoBrakeMass property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MaxAutoBrakeMassValueSpecified { get; set; }
        
        /// <summary>
        /// <para>maximum brake mass of automatic brake</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> MaxAutoBrakeMass
        {
            get
            {
                if (this.MaxAutoBrakeMassValueSpecified)
                {
                    return this.MaxAutoBrakeMassValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxAutoBrakeMassValue = value.GetValueOrDefault();
                this.MaxAutoBrakeMassValueSpecified = value.HasValue;
            }
        }
    }
}
