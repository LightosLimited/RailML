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
    /// <para>vehicle related data</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tVehicle", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EVehicle))]
    internal partial class TVehicle : genericRailML.TElementWithIDAndName, IAVehicle
    {
        
        /// <summary>
        /// <para>reference to 'id' in vehicle data in order to obtain all data common for the vehicle family not explicitly specified in this element of an individual vehicle</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [XmlAttributeAttribute("vehicleFamilyRef")]
        public string VehicleFamilyRef { get; set; }
        
        /// <summary>
        /// <para>basic vehicle category used for train formation planning</para>
        /// </summary>
        [XmlAttributeAttribute("vehicleCategory")]
        public string VehicleCategory { get; set; }
        
        /// <summary>
        /// <para>description of axle sequence</para>
        /// </summary>
        [XmlAttributeAttribute("axleSequence")]
        public string AxleSequence { get; set; }
        
        /// <summary>
        /// <para>the number of motored axles used for traction</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        [XmlAttributeAttribute("numberDrivenAxles")]
        public string NumberDrivenAxles { get; set; }
        
        /// <summary>
        /// <para>the number of axles not used for traction (without motor or gear)</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        [XmlAttributeAttribute("numberNonDrivenAxles")]
        public string NumberNonDrivenAxles { get; set; }
        
        /// <summary>
        /// <para>the track gauge in metres the vehicle is mainly used for</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("trackGauge")]
        public decimal TrackGaugeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrackGauge-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TrackGauge property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TrackGaugeValueSpecified { get; set; }
        
        /// <summary>
        /// <para>the track gauge in metres the vehicle is mainly used for</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TrackGauge
        {
            get
            {
                if (this.TrackGaugeValueSpecified)
                {
                    return this.TrackGaugeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TrackGaugeValue = value.GetValueOrDefault();
                this.TrackGaugeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>the track gauge in metres the vehicle is alternatively used for</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("trackGaugeAlternative")]
        public decimal TrackGaugeAlternativeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrackGaugeAlternative-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TrackGaugeAlternative property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TrackGaugeAlternativeValueSpecified { get; set; }
        
        /// <summary>
        /// <para>the track gauge in metres the vehicle is alternatively used for</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TrackGaugeAlternative
        {
            get
            {
                if (this.TrackGaugeAlternativeValueSpecified)
                {
                    return this.TrackGaugeAlternativeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TrackGaugeAlternativeValue = value.GetValueOrDefault();
                this.TrackGaugeAlternativeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>the vehicle comprises wheelsets adjustable to different track gauge</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("adjustableWheelSet")]
        public bool AdjustableWheelSetValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdjustableWheelSet-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AdjustableWheelSet property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AdjustableWheelSetValueSpecified { get; set; }
        
        /// <summary>
        /// <para>the vehicle comprises wheelsets adjustable to different track gauge</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> AdjustableWheelSet
        {
            get
            {
                if (this.AdjustableWheelSetValueSpecified)
                {
                    return this.AdjustableWheelSetValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AdjustableWheelSetValue = value.GetValueOrDefault();
                this.AdjustableWheelSetValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>vehicle length in metres</para>
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
        /// <para>vehicle length in metres</para>
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
        /// <para>maximum allowed vehicle speed in km/h</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("speed")]
        public decimal SpeedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Speed-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Speed property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SpeedValueSpecified { get; set; }
        
        /// <summary>
        /// <para>maximum allowed vehicle speed in km/h</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> Speed
        {
            get
            {
                if (this.SpeedValueSpecified)
                {
                    return this.SpeedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SpeedValue = value.GetValueOrDefault();
                this.SpeedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>maximum allowed vehicle speed in km/h when its towed (not powered)</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("towingSpeed")]
        public decimal TowingSpeedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TowingSpeed-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TowingSpeed property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TowingSpeedValueSpecified { get; set; }
        
        /// <summary>
        /// <para>maximum allowed vehicle speed in km/h when its towed (not powered)</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TowingSpeed
        {
            get
            {
                if (this.TowingSpeedValueSpecified)
                {
                    return this.TowingSpeedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TowingSpeedValue = value.GetValueOrDefault();
                this.TowingSpeedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>total weight of vehicle with full payload in metric tons (gross weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("bruttoWeight")]
        public decimal BruttoWeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BruttoWeight-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BruttoWeight property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BruttoWeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>total weight of vehicle with full payload in metric tons (gross weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> BruttoWeight
        {
            get
            {
                if (this.BruttoWeightValueSpecified)
                {
                    return this.BruttoWeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BruttoWeightValue = value.GetValueOrDefault();
                this.BruttoWeightValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>net weight of vehicle payload in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("nettoWeight")]
        public decimal NettoWeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NettoWeight-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NettoWeight property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NettoWeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>net weight of vehicle payload in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> NettoWeight
        {
            get
            {
                if (this.NettoWeightValueSpecified)
                {
                    return this.NettoWeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NettoWeightValue = value.GetValueOrDefault();
                this.NettoWeightValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>tare weight of vehicle (empty) in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("tareWeight")]
        public decimal TareWeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TareWeight-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TareWeight property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TareWeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>tare weight of vehicle (empty) in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TareWeight
        {
            get
            {
                if (this.TareWeightValueSpecified)
                {
                    return this.TareWeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TareWeightValue = value.GetValueOrDefault();
                this.TareWeightValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>portion of total vehicle weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("bruttoAdhesionWeight")]
        public decimal BruttoAdhesionWeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BruttoAdhesionWeight-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BruttoAdhesionWeight property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool BruttoAdhesionWeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>portion of total vehicle weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> BruttoAdhesionWeight
        {
            get
            {
                if (this.BruttoAdhesionWeightValueSpecified)
                {
                    return this.BruttoAdhesionWeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BruttoAdhesionWeightValue = value.GetValueOrDefault();
                this.BruttoAdhesionWeightValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>portion of tare vehicle weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("tareAdhesionWeight")]
        public decimal TareAdhesionWeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TareAdhesionWeight-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TareAdhesionWeight property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool TareAdhesionWeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>portion of tare vehicle weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> TareAdhesionWeight
        {
            get
            {
                if (this.TareAdhesionWeightValueSpecified)
                {
                    return this.TareAdhesionWeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TareAdhesionWeightValue = value.GetValueOrDefault();
                this.TareAdhesionWeightValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>DEPRECATED: portion of vehicle payload weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("nettoAdhesionWeight")]
        public decimal NettoAdhesionWeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die NettoAdhesionWeight-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the NettoAdhesionWeight property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool NettoAdhesionWeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED: portion of vehicle payload weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> NettoAdhesionWeight
        {
            get
            {
                if (this.NettoAdhesionWeightValueSpecified)
                {
                    return this.NettoAdhesionWeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.NettoAdhesionWeightValue = value.GetValueOrDefault();
                this.NettoAdhesionWeightValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>weight per axle of vehicle in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("axleLoad")]
        public decimal AxleLoadValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AxleLoad-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AxleLoad property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AxleLoadValueSpecified { get; set; }
        
        /// <summary>
        /// <para>weight per axle of vehicle in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> AxleLoad
        {
            get
            {
                if (this.AxleLoadValueSpecified)
                {
                    return this.AxleLoadValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AxleLoadValue = value.GetValueOrDefault();
                this.AxleLoadValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>running resistance of vehicle in N/kN (to be used in conjunction with 'trainResistance' element</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("resistanceFactor")]
        public decimal ResistanceFactorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ResistanceFactor-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ResistanceFactor property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ResistanceFactorValueSpecified { get; set; }
        
        /// <summary>
        /// <para>running resistance of vehicle in N/kN (to be used in conjunction with 'trainResistance' element</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> ResistanceFactor
        {
            get
            {
                if (this.ResistanceFactorValueSpecified)
                {
                    return this.ResistanceFactorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ResistanceFactorValue = value.GetValueOrDefault();
                this.ResistanceFactorValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>vehicle may run at the train head</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("onTrainHead")]
        public bool OnTrainHeadValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OnTrainHead-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnTrainHead property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OnTrainHeadValueSpecified { get; set; }
        
        /// <summary>
        /// <para>vehicle may run at the train head</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> OnTrainHead
        {
            get
            {
                if (this.OnTrainHeadValueSpecified)
                {
                    return this.OnTrainHeadValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnTrainHeadValue = value.GetValueOrDefault();
                this.OnTrainHeadValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>vehicle must be the last one in any formation, no other vehicle coupled to its end</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("onTrainTailOnly")]
        public bool OnTrainTailOnlyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OnTrainTailOnly-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnTrainTailOnly property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OnTrainTailOnlyValueSpecified { get; set; }
        
        /// <summary>
        /// <para>vehicle must be the last one in any formation, no other vehicle coupled to its end</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> OnTrainTailOnly
        {
            get
            {
                if (this.OnTrainTailOnlyValueSpecified)
                {
                    return this.OnTrainTailOnlyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnTrainTailOnlyValue = value.GetValueOrDefault();
                this.OnTrainTailOnlyValueSpecified = value.HasValue;
            }
        }
    }
}
