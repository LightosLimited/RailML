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
    [System.Xml.Serialization.XmlTypeAttribute("tOperationModeChange", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TOperationModeChange : TStrictOrientedElement, IAOperationMode
    {
        
        [System.Xml.Serialization.XmlAttributeAttribute("modeLegislative")]
        public string ModeLegislative { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("modeExecutive")]
        public string ModeExecutive { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("clearanceManaging")]
        public string ClearanceManaging { get; set; }
    }
}
