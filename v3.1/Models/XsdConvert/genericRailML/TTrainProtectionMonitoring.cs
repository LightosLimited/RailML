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
    
    
    /// <summary>
    /// <para>classification of a train protection system by coverage</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tTrainProtectionMonitoring", Namespace="https://www.railml.org/schemas/2018")]
    internal enum TTrainProtectionMonitoring
    {
        
        [System.Xml.Serialization.XmlEnumAttribute("none")]
        None,
        
        [System.Xml.Serialization.XmlEnumAttribute("intermittent")]
        Intermittent,
        
        [System.Xml.Serialization.XmlEnumAttribute("continuous")]
        Continuous,
    }
}
