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
    [XmlTypeAttribute("tStrictOrientedElement", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(TAxleWeightChange))]
    [XmlIncludeAttribute(typeof(TClearanceGaugeChange))]
    [XmlIncludeAttribute(typeof(TElectrificationChange))]
    [XmlIncludeAttribute(typeof(TGaugeChange))]
    [XmlIncludeAttribute(typeof(TGradientChange))]
    [XmlIncludeAttribute(typeof(TOperationModeChange))]
    [XmlIncludeAttribute(typeof(TOwnerChange))]
    [XmlIncludeAttribute(typeof(TPowerTransmissionChange))]
    [XmlIncludeAttribute(typeof(TRadiusChange))]
    [XmlIncludeAttribute(typeof(TSpeedChange))]
    [XmlIncludeAttribute(typeof(TTrainProtectionChange))]
    internal partial class TStrictOrientedElement : TPlacedElement, IAStrictOrientation
    {
        
        /// <summary>
        /// <para>a strict direction, which allows only for "up" and "down"</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("dir")]
        public genericRailML.TStrictDirection DirValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Dir-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Dir property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DirValueSpecified { get; set; }
        
        /// <summary>
        /// <para>a strict direction, which allows only for "up" and "down"</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<genericRailML.TStrictDirection> Dir
        {
            get
            {
                if (this.DirValueSpecified)
                {
                    return this.DirValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DirValue = value.GetValueOrDefault();
                this.DirValueSpecified = value.HasValue;
            }
        }
    }
}