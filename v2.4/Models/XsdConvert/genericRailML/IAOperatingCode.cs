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
    internal partial interface IAOperatingCode
    {
        
        /// <summary>
        /// <para xml:lang="en">Pattern: [0-1]{7}.</para>
        /// </summary>
        [RegularExpressionAttribute("[0-1]{7}")]
        string OperatingCode
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>needed for "runs Monday to Friday and additionally Sunday on request"</para>
        /// </summary>
        System.Nullable<bool> OnRequest
        {
            get;
            set;
        }
    }
}
