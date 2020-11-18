//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace Models.DB
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    /// <summary>
    /// <para>data for passenger flow speed</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tPassengerFlowSpeed", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TPassengerFlowSpeed : IAPassengerFlowSpeed
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>average/planned number of passengers per second that can flow through the doors and vestibules of the vehicle at given platform heights</para>
        /// <para>number of passengers per second used for flow description</para>
        /// <para xml:lang="en">Total number of digits in fraction: 3.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("flowSpeed")]
        public decimal FlowSpeedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die FlowSpeed-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the FlowSpeed property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool FlowSpeedValueSpecified { get; set; }
        
        /// <summary>
        /// <para>average/planned number of passengers per second that can flow through the doors and vestibules of the vehicle at given platform heights</para>
        /// <para>number of passengers per second used for flow description</para>
        /// <para xml:lang="en">Total number of digits in fraction: 3.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> FlowSpeed
        {
            get
            {
                if (this.FlowSpeedValueSpecified)
                {
                    return this.FlowSpeedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FlowSpeedValue = value.GetValueOrDefault();
                this.FlowSpeedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>platform height in millimetres for a given flow speed</para>
        /// <para>generic type for length values measured in millimeter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("platformHeight")]
        public decimal PlatformHeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die PlatformHeight-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the PlatformHeight property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PlatformHeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>platform height in millimetres for a given flow speed</para>
        /// <para>generic type for length values measured in millimeter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> PlatformHeight
        {
            get
            {
                if (this.PlatformHeightValueSpecified)
                {
                    return this.PlatformHeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PlatformHeightValue = value.GetValueOrDefault();
                this.PlatformHeightValueSpecified = value.HasValue;
            }
        }
    }
}