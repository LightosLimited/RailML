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
    internal partial interface IALineClassification
    {
        
        /// <summary>
        /// <para>the name of the line class according RIV or any other distinctive name</para>
        /// <para>according EN 15528 (other national values also possible)</para>
        /// </summary>
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>permissible payload for the vehicle with respect to line classification</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        decimal PayLoad
        {
            get;
            set;
        }
    }
}
