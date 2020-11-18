//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace Models.DB
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>container for rolling stock data of single vehicles and train formations</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("rollingstock", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("rollingstock", Namespace="https://www.railml.org/schemas/2018")]
    internal partial class Rollingstock : TRollingstock
    {
        
        /// <summary>
        /// <para>container for single vehicle data or vehicle family data</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("vehicles", Order=0)]
        public EVehicles Vehicles { get; set; }
        
        /// <summary>
        /// <para>container for complete train formations or sets of vehicles</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("formations", Order=1)]
        public EFormations Formations { get; set; }
    }
}