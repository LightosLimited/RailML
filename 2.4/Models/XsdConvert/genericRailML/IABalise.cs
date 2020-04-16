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
    internal partial interface IABalise
    {
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1023.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0", "1023")]
        string CountryID
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 16383.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0", "16383")]
        string GroupID
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para xml:lang="en">Minimum inclusive value: -63.</para>
        /// <para xml:lang="en">Maximum inclusive value: 63.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "-63", "63")]
        string LinkingAccuracy
        {
            get;
            set;
        }
        
        System.Nullable<TBaliseLinkReaction> LinkReactionAscending
        {
            get;
            set;
        }
        
        System.Nullable<TBaliseLinkReaction> LinkReactionDescending
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>telegram coded to the balise; representation of the binary as hex string</para>
        /// <para>an arbitrary string consisting of hex digits from 0 to 9, a to f; not allowing white space, letters; no length restriction</para>
        /// <para xml:lang="en">Pattern: [0-9a-fA-F]*.</para>
        /// </summary>
        [RegularExpressionAttribute("[0-9a-fA-F]*")]
        string StaticTelegram
        {
            get;
            set;
        }
    }
}
