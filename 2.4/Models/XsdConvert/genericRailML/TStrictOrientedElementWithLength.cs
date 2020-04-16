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
    [System.Xml.Serialization.XmlTypeAttribute("tStrictOrientedElementWithLength", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TBaseServiceSection))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TPlatformEdge))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TServiceSection))]
    internal partial class TStrictOrientedElementWithLength : TPlacedElementWithLength, IAStrictOrientation
    {
        
        /// <summary>
        /// <para>a strict direction, which allows only for "up" and "down"</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("dir")]
        public genericRailML.TStrictDirection DirValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Dir-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Dir property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DirValueSpecified { get; set; }
        
        /// <summary>
        /// <para>a strict direction, which allows only for "up" and "down"</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
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
