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
    /// <para>planned/calculated usage of specified brakes</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tBrakeUse", Namespace="https://www.railml.org/schemas/2018")]
    internal enum TBrakeUse
    {
        
        [XmlEnumAttribute("unknown")]
        Unknown,
        
        [XmlEnumAttribute("normal")]
        Normal,
        
        [XmlEnumAttribute("emergency")]
        Emergency,
        
        [XmlEnumAttribute("both")]
        Both,
    }
}
