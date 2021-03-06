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
    [System.Xml.Serialization.XmlTypeAttribute("tBaseServiceSection", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TPlatformEdge))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TServiceSection))]
    internal partial class TBaseServiceSection : TStrictOrientedElementWithLength, genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para>height above the rails in millimeters</para>
        /// <para>generic type for length values measured in millimeter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("height")]
        public decimal HeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Height-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Height property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool HeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>height above the rails in millimeters</para>
        /// <para>generic type for length values measured in millimeter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> Height
        {
            get
            {
                if (this.HeightValueSpecified)
                {
                    return this.HeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HeightValue = value.GetValueOrDefault();
                this.HeightValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>side as seen from the oriented track, e.g. left or right</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("side")]
        public TSide SideValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Side-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Side property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SideValueSpecified { get; set; }
        
        /// <summary>
        /// <para>side as seen from the oriented track, e.g. left or right</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<TSide> Side
        {
            get
            {
                if (this.SideValueSpecified)
                {
                    return this.SideValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SideValue = value.GetValueOrDefault();
                this.SideValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>reference to the OCP, where the platform edge / service section belongs to</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ocpRef")]
        public string OcpRef { get; set; }
    }
}
