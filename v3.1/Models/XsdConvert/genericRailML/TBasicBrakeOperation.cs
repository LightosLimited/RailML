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
    
    
    /// <summary>
    /// <para>data type for description of brake operation</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tBasicBrakeOperation", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TBasicBrakeOperation : IABasicBrakeOperation
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("decelerationTable", Order=0)]
        public TDecelerationCurve DecelerationTable { get; set; }
        
        /// <summary>
        /// <para>possible values for selection of different brake operation rules</para>
        /// <para>list of possible brake supervision regimes causing different operational behaviour during braking</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("brakeSupervision")]
        public string BrakeSupervision { get; set; }
        
        /// <summary>
        /// <para>average brake application time, typically in seconds</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("decelerationDelay")]
        public string DecelerationDelay { get; set; }
        
        /// <summary>
        /// <para>below this speed limit in km/h generally the supervision regime of "none" shall apply</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("releaseSpeed")]
        public decimal ReleaseSpeedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ReleaseSpeed-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the ReleaseSpeed property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ReleaseSpeedValueSpecified { get; set; }
        
        /// <summary>
        /// <para>below this speed limit in km/h generally the supervision regime of "none" shall apply</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> ReleaseSpeed
        {
            get
            {
                if (this.ReleaseSpeedValueSpecified)
                {
                    return this.ReleaseSpeedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ReleaseSpeedValue = value.GetValueOrDefault();
                this.ReleaseSpeedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>average deceleration value in this supervision regime in m/s^2</para>
        /// <para>generic type for acceleration values measured in meter per square second</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("meanDeceleration")]
        public decimal MeanDecelerationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeanDeceleration-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MeanDeceleration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MeanDecelerationValueSpecified { get; set; }
        
        /// <summary>
        /// <para>average deceleration value in this supervision regime in m/s^2</para>
        /// <para>generic type for acceleration values measured in meter per square second</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> MeanDeceleration
        {
            get
            {
                if (this.MeanDecelerationValueSpecified)
                {
                    return this.MeanDecelerationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MeanDecelerationValue = value.GetValueOrDefault();
                this.MeanDecelerationValueSpecified = value.HasValue;
            }
        }
    }
}
