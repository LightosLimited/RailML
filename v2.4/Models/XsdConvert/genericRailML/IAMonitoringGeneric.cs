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
    internal partial interface IAMonitoringGeneric
    {
        
        /// <summary>
        /// <para>identification of the on-board unit used for addressing within communication</para>
        /// </summary>
        string OnBoardUnitID
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>version of installed software of the system</para>
        /// <para>an arbitrary version number for any system; allowing digits, letters and white space</para>
        /// </summary>
        string SoftwareVersion
        {
            get;
            set;
        }
    }
}
