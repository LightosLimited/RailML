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
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tDerailKind", Namespace="https://www.railml.org/schemas/2018")]
    internal enum TDerailKind
    {
        
        /// <summary>
        /// <para>see book "Railway Signalling and Interlocking", p. 155</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("blockDerail")]
        BlockDerail,
        
        /// <summary>
        /// <para>see book "Railway Signalling and Interlocking", p. 155</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("singleCatchPoints")]
        SingleCatchPoints,
        
        /// <summary>
        /// <para>see book "Railway Signalling and Interlocking", p. 155</para>
        /// </summary>
        [System.Xml.Serialization.XmlEnumAttribute("doubleCatchPoints")]
        DoubleCatchPoints,
    }
}
