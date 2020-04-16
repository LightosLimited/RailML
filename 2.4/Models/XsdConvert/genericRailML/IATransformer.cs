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
    internal partial interface IATransformer
    {
        
        /// <summary>
        /// <para>resistance of iron core of one transformer in Ohms (open-circuit core loss)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        System.Nullable<decimal> FerrumResistance
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>additional resistance of one transformer in Ohms due to non-sinusoid currents (stray loss)</para>
        /// <para>generic type for electric resistance values measured in ohm</para>
        /// </summary>
        System.Nullable<decimal> AdditionalResistance
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>main inductance of one transformer in H</para>
        /// <para>generic type for inductance values measured in henry</para>
        /// </summary>
        System.Nullable<decimal> MainInductance
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>The transformer mean efficiency in the range 0..1.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0", "1")]
        System.Nullable<decimal> MeanEfficiency
        {
            get;
            set;
        }
    }
}
