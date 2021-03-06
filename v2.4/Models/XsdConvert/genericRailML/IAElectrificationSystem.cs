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
    /// <para>nominal values (voltage + frequency) of electrification system</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    internal partial interface IAElectrificationSystem
    {
        
        /// <summary>
        /// <para>as values (not enumeration)!!</para>
        /// <para>generic type for voltage values measured in volt</para>
        /// </summary>
        System.Nullable<decimal> Voltage
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>for DC the frequency shall be set to Zero</para>
        /// <para>generic type for frequency values measured in hertz</para>
        /// </summary>
        System.Nullable<decimal> Frequency
        {
            get;
            set;
        }
    }
}
