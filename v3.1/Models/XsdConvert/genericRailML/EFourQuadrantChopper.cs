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
    [System.Xml.Serialization.XmlTypeAttribute("eFourQuadrantChopper", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EFourQuadrantChopper : genericRailML.TFourQuadrantChopper
    {
        
        /// <summary>
        /// <para>four-quadrant-chopper efficiency vs. speed</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("efficiency", Order=0)]
        public genericRailML.TEfficiencyCurve Efficiency { get; set; }
        
        /// <summary>
        /// <para>phase angle of the real power to the apparent power as curve for the entire propulsion system</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("phi", Order=1)]
        public genericRailML.TCurve Phi { get; set; }
    }
}
