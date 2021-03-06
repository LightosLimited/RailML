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
    /// <summary>
    /// <para>engine data about a motor car or locomotive</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tEngine", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EEngine))]
    internal partial class TEngine : IAEngine
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>way of transmitting the torque onto axle</para>
        /// </summary>
        [XmlAttributeAttribute("axleDriveType")]
        public string AxleDriveType { get; set; }
        
        /// <summary>
        /// <para>permissible load attached to the vehicle in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("haulageLoad")]
        public decimal HaulageLoadValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die HaulageLoad-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the HaulageLoad property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool HaulageLoadValueSpecified { get; set; }
        
        /// <summary>
        /// <para>permissible load attached to the vehicle in metric tons</para>
        /// <para>generic type for weight/load values measured in ton</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> HaulageLoad
        {
            get
            {
                if (this.HaulageLoadValueSpecified)
                {
                    return this.HaulageLoadValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HaulageLoadValue = value.GetValueOrDefault();
                this.HaulageLoadValueSpecified = value.HasValue;
            }
        }
    }
}
