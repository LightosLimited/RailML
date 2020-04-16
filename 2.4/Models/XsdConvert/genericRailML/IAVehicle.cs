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
    internal partial interface IAVehicle
    {
        
        /// <summary>
        /// <para>reference to 'id' in vehicle data in order to obtain all data common for the vehicle family not explicitly specified in this element of an individual vehicle</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string VehicleFamilyRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>basic vehicle category used for train formation planning</para>
        /// </summary>
        string VehicleCategory
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>description of axle sequence</para>
        /// </summary>
        string AxleSequence
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the number of motored axles used for traction</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string NumberDrivenAxles
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the number of axles not used for traction (without motor or gear)</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string NumberNonDrivenAxles
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the track gauge in metres the vehicle is mainly used for</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> TrackGauge
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the track gauge in metres the vehicle is alternatively used for</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> TrackGaugeAlternative
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the vehicle comprises wheelsets adjustable to different track gauge</para>
        /// </summary>
        System.Nullable<bool> AdjustableWheelSet
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>vehicle length in metres</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> Length
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>maximum allowed vehicle speed in km/h</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        System.Nullable<decimal> Speed
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>maximum allowed vehicle speed in km/h when its towed (not powered)</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        System.Nullable<decimal> TowingSpeed
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>total weight of vehicle with full payload in metric tons (gross weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> BruttoWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>net weight of vehicle payload in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> NettoWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>tare weight of vehicle (empty) in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> TareWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>portion of total vehicle weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> BruttoAdhesionWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>portion of tare vehicle weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> TareAdhesionWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED: portion of vehicle payload weight on motored axles in metric tons (adhesion weight)</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> NettoAdhesionWeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>weight per axle of vehicle in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        System.Nullable<decimal> AxleLoad
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>running resistance of vehicle in N/kN (to be used in conjunction with 'trainResistance' element</para>
        /// </summary>
        System.Nullable<decimal> ResistanceFactor
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>vehicle may run at the train head</para>
        /// </summary>
        System.Nullable<bool> OnTrainHead
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>vehicle must be the last one in any formation, no other vehicle coupled to its end</para>
        /// </summary>
        System.Nullable<bool> OnTrainTailOnly
        {
            get;
            set;
        }
    }
}
