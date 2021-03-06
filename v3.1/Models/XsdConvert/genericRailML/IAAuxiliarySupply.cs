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
    internal partial interface IAAuxiliarySupply
    {
        
        /// <summary>
        /// <para>power consumption of constant load by auxiliary equipment in Watt (permanent)</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        decimal Power
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>phase angle phi of constant power of auxiliary load between -180..+180</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-180", "180")]
        System.Nullable<decimal> PowerPhi
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>resistance of constant load by auxiliary equipment in Ohm</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        System.Nullable<decimal> Resistance
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>power consumption of constant load by auxiliary equipment in Watt (only during braking mode)</para>
        /// <para>generic type for power values measured in watt</para>
        /// </summary>
        System.Nullable<decimal> PowerBraking
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>phase angle phi of constant power of auxiliary load between -180..+180 (only during braking mode)</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-180", "180")]
        System.Nullable<decimal> PowerPhiBraking
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>resistance of constant load by auxiliary equipment in Ohm (only during braking mode)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        System.Nullable<decimal> ResistanceBraking
        {
            get;
            set;
        }
    }
}
