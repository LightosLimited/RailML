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
    internal partial interface IAFourQuadrantChopper
    {
        
        /// <summary>
        /// <para>average phase angle phi of four-quadrant-chopper (in traction mode)</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-180", "180")]
        System.Nullable<decimal> MeanPhi
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>average phase angle phi of four-quadrant-chopper in regeneration mode</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-180", "180")]
        System.Nullable<decimal> MeanPhiRegeneration
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>The four quadrant chopper mean efficiency in the range 0..1.</para>
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
    }
}
