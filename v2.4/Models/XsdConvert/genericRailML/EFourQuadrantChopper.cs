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
    [SerializableAttribute()]
    [XmlTypeAttribute("eFourQuadrantChopper", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EFourQuadrantChopper : genericRailML.TFourQuadrantChopper
    {
        
        /// <summary>
        /// <para>four-quadrant-chopper efficiency vs. speed</para>
        /// </summary>
        [XmlElementAttribute("efficiency", Order=0)]
        public genericRailML.TEfficiencyCurve Efficiency { get; set; }
        
        /// <summary>
        /// <para>phase angle of the real power to the apparent power as curve for the entire propulsion system</para>
        /// </summary>
        [XmlElementAttribute("phi", Order=1)]
        public genericRailML.TCurve Phi { get; set; }
    }
}
