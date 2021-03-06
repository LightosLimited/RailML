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
    [XmlTypeAttribute("tSignalEtcs", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TSignalEtcs : TSignalBase, IAETCS
    {
        
        /// <summary>
        /// <para>Version of ETCS language (SRS edition) installed</para>
        /// <para>an arbitrary version number for any system; allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("srsVersion")]
        public string SrsVersion { get; set; }
        
        /// <summary>
        /// <para>on-board unit supports level 0</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("level_0")]
        public bool Level_0Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Level_0-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Level_0 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Level_0ValueSpecified { get; set; }
        
        /// <summary>
        /// <para>on-board unit supports level 0</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> Level_0
        {
            get
            {
                if (this.Level_0ValueSpecified)
                {
                    return this.Level_0Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Level_0Value = value.GetValueOrDefault();
                this.Level_0ValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>on-board unit supports level 1</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("level_1")]
        public bool Level_1Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Level_1-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Level_1 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Level_1ValueSpecified { get; set; }
        
        /// <summary>
        /// <para>on-board unit supports level 1</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> Level_1
        {
            get
            {
                if (this.Level_1ValueSpecified)
                {
                    return this.Level_1Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Level_1Value = value.GetValueOrDefault();
                this.Level_1ValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>on-board unit supports level 2</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("level_2")]
        public bool Level_2Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Level_2-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Level_2 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Level_2ValueSpecified { get; set; }
        
        /// <summary>
        /// <para>on-board unit supports level 2</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> Level_2
        {
            get
            {
                if (this.Level_2ValueSpecified)
                {
                    return this.Level_2Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Level_2Value = value.GetValueOrDefault();
                this.Level_2ValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>on-board unit supports level 3</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("level_3")]
        public bool Level_3Value { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Level_3-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Level_3 property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool Level_3ValueSpecified { get; set; }
        
        /// <summary>
        /// <para>on-board unit supports level 3</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> Level_3
        {
            get
            {
                if (this.Level_3ValueSpecified)
                {
                    return this.Level_3Value;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.Level_3Value = value.GetValueOrDefault();
                this.Level_3ValueSpecified = value.HasValue;
            }
        }
    }
}
