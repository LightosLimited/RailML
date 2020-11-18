//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace Models.XsdConvert.genericRailML
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    internal partial interface IAGear
    {
        
        /// <summary>
        /// <para>gear ratio as decimal value</para>
        /// </summary>
        System.Nullable<decimal> GearRatio
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the gear mean efficiency in the range 0..1.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1")]
        System.Nullable<decimal> MeanEfficiency
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>design type of the gear</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        string DesignType
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>manufacturer of the gear</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        string ManufacturerName
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>nominal power of the gear for transmission</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        System.Nullable<decimal> NominalPower
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>type of torque conversion between motor and axle gear, mainly for diesel-hydraulic vehicles</para>
        /// </summary>
        string TorqueConversion
        {
            get;
            set;
        }
    }
}