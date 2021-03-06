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
    [XmlTypeAttribute("tBlock", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EBlock))]
    internal partial class TBlock : genericRailML.TElementWithIDAndName, IABlock
    {
        
        [XmlAttributeAttribute("blockGroupNumber")]
        public string BlockGroupNumber { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("fixed")]
        public bool FixedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Fixed-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Fixed property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool FixedValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> Fixed
        {
            get
            {
                if (this.FixedValueSpecified)
                {
                    return this.FixedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FixedValue = value.GetValueOrDefault();
                this.FixedValueSpecified = value.HasValue;
            }
        }
    }
}
