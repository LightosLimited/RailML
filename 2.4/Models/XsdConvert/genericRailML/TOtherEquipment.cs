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
    /// <para>container for other installed train equipment (non-safety)</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tOtherEquipment", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TOtherEquipment : genericRailML.TElementWithIDAndName, IAMonitoringGeneric
    {
        
        /// <summary>
        /// <para>identification of the on-board unit used for addressing within communication</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("onBoardUnitID")]
        public string OnBoardUnitID { get; set; }
        
        /// <summary>
        /// <para>version of installed software of the system</para>
        /// <para>an arbitrary version number for any system; allowing digits, letters and white space</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("softwareVersion")]
        public string SoftwareVersion { get; set; }
    }
}
