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
    [XmlTypeAttribute("tCrossSection", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TCrossSection : TPlacedElement
    {
        
        [XmlAttributeAttribute("type")]
        public string Type { get; set; }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [XmlAttributeAttribute("ocpRef")]
        public string OcpRef { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED since it is not needed anymore (for defining platforms, please use the platform element instead)</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("ocpTrackID")]
        public byte OcpTrackIDValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OcpTrackID-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OcpTrackID property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OcpTrackIDValueSpecified { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED since it is not needed anymore (for defining platforms, please use the platform element instead)</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<byte> OcpTrackID
        {
            get
            {
                if (this.OcpTrackIDValueSpecified)
                {
                    return this.OcpTrackIDValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OcpTrackIDValue = value.GetValueOrDefault();
                this.OcpTrackIDValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>DEPRECATED since it is not needed here.</para>
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
        /// <para>DEPRECATED since it is not needed here.</para>
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
        
        /// <summary>
        /// <para>relative direction starting from the relevant track towards the "operational center" of the OCP</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("ocpCenterSide")]
        public TOcpCenterSide OcpCenterSideValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OcpCenterSide-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OcpCenterSide property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OcpCenterSideValueSpecified { get; set; }
        
        /// <summary>
        /// <para>relative direction starting from the relevant track towards the "operational center" of the OCP</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<TOcpCenterSide> OcpCenterSide
        {
            get
            {
                if (this.OcpCenterSideValueSpecified)
                {
                    return this.OcpCenterSideValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OcpCenterSideValue = value.GetValueOrDefault();
                this.OcpCenterSideValueSpecified = value.HasValue;
            }
        }
    }
}
