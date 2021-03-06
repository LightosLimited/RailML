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
    [XmlTypeAttribute("tRadiusChange", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TRadiusChange : TStrictOrientedElement, IARadiusChange
    {
        
        /// <summary>
        /// <para>The radius of the track in [m], which is either valid exactly at this point or from here until the next radiusChange element.</para>
        /// <para>generic type for radius values measured in meter</para>
        /// </summary>
        [XmlAttributeAttribute("radius")]
        public decimal Radius { get; set; }
        
        /// <summary>
        /// <para>The superelevation of the track in [mm], which is either valid exactly at this point of from here until the next radiusChange element.</para>
        /// <para>generic type for length values measured in millimeter</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("superelevation")]
        public decimal SuperelevationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Superelevation-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Superelevation property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SuperelevationValueSpecified { get; set; }
        
        /// <summary>
        /// <para>The superelevation of the track in [mm], which is either valid exactly at this point of from here until the next radiusChange element.</para>
        /// <para>generic type for length values measured in millimeter</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> Superelevation
        {
            get
            {
                if (this.SuperelevationValueSpecified)
                {
                    return this.SuperelevationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SuperelevationValue = value.GetValueOrDefault();
                this.SuperelevationValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>Specific geometric description either of this point or of the curve between this and the next radiusChange element (shall be used in particular for transition curves).</para>
        /// </summary>
        [XmlAttributeAttribute("geometryElementDescription")]
        public string GeometryElementDescription { get; set; }
    }
}
