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
    [XmlTypeAttribute("tOrientedElement", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(TBalise))]
    [XmlIncludeAttribute(typeof(TDerailer))]
    [XmlIncludeAttribute(typeof(TLock))]
    [XmlIncludeAttribute(typeof(TRuleCodeElement))]
    [XmlIncludeAttribute(typeof(TSignal))]
    [XmlIncludeAttribute(typeof(TStopPost))]
    [XmlIncludeAttribute(typeof(TTrainProtectionElement))]
    [XmlIncludeAttribute(typeof(TTrainRadioChange))]
    internal partial class TOrientedElement : TPlacedElement, IAOrientation
    {
        
        /// <summary>
        /// <para>a direction, which allows for all direction attributes</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("dir")]
        public genericRailML.TLaxDirection DirValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Dir-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Dir property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DirValueSpecified { get; set; }
        
        /// <summary>
        /// <para>a direction, which allows for all direction attributes</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<genericRailML.TLaxDirection> Dir
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
