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
    /// <para>generic type for more constrained direction statements</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tExtendedDirection", Namespace="https://www.railml.org/schemas/2018")]
    internal enum TExtendedDirection
    {
        
        [XmlEnumAttribute("up")]
        Up,
        
        [XmlEnumAttribute("down")]
        Down,
        
        [XmlEnumAttribute("unknown")]
        Unknown,
        
        [XmlEnumAttribute("none")]
        None,
    }
}
