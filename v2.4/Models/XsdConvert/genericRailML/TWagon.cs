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
    /// <para>technical and payload data about a car</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tWagon", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EWagon))]
    internal partial class TWagon : IAWagon
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>factor for increased running resistance by rotating masses of non-motored axles</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("rotationMassFactor")]
        public decimal RotationMassFactorValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die RotationMassFactor-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the RotationMassFactor property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool RotationMassFactorValueSpecified { get; set; }
        
        /// <summary>
        /// <para>factor for increased running resistance by rotating masses of non-motored axles</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> RotationMassFactor
        {
            get
            {
                if (this.RotationMassFactorValueSpecified)
                {
                    return this.RotationMassFactorValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RotationMassFactorValue = value.GetValueOrDefault();
                this.RotationMassFactorValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>additional mass for increased running resistance by rotating masses of non-motored axles</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("additionalRotationMass")]
        public decimal AdditionalRotationMassValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalRotationMass-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AdditionalRotationMass property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AdditionalRotationMassValueSpecified { get; set; }
        
        /// <summary>
        /// <para>additional mass for increased running resistance by rotating masses of non-motored axles</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> AdditionalRotationMass
        {
            get
            {
                if (this.AdditionalRotationMassValueSpecified)
                {
                    return this.AdditionalRotationMassValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AdditionalRotationMassValue = value.GetValueOrDefault();
                this.AdditionalRotationMassValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>name of car body kinematic envelope as reference</para>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("kinematicEnvelope")]
        public string KinematicEnvelope { get; set; }
        
        /// <summary>
        /// <para>continuous power consumption in Watt of auxiliaries within one car</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("auxiliaryPowerConsumption")]
        public decimal AuxiliaryPowerConsumptionValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AuxiliaryPowerConsumption-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the AuxiliaryPowerConsumption property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool AuxiliaryPowerConsumptionValueSpecified { get; set; }
        
        /// <summary>
        /// <para>continuous power consumption in Watt of auxiliaries within one car</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> AuxiliaryPowerConsumption
        {
            get
            {
                if (this.AuxiliaryPowerConsumptionValueSpecified)
                {
                    return this.AuxiliaryPowerConsumptionValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.AuxiliaryPowerConsumptionValue = value.GetValueOrDefault();
                this.AuxiliaryPowerConsumptionValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>basic definition of head shape in order to derive air resistance of the vehicle</para>
        /// </summary>
        [XmlAttributeAttribute("headShape")]
        public string HeadShape { get; set; }
        
        /// <summary>
        /// <para>cross-section area of vehicle front in order to derive air resistance of the vehicle</para>
        /// <para>generic type for area values measured in square meter</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("headSurface")]
        public decimal HeadSurfaceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HeadSurface-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HeadSurface property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HeadSurfaceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>cross-section area of vehicle front in order to derive air resistance of the vehicle</para>
        /// <para>generic type for area values measured in square meter</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> HeadSurface
        {
            get
            {
                if (this.HeadSurfaceValueSpecified)
                {
                    return this.HeadSurfaceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HeadSurfaceValue = value.GetValueOrDefault();
                this.HeadSurfaceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>describes the type of the bearing used for calculating vehicle resistance</para>
        /// </summary>
        [XmlAttributeAttribute("bearingType")]
        public string BearingType { get; set; }
    }
}
