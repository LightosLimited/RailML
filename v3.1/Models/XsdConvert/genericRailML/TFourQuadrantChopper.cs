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
    /// <para>technical data of inverter between OHL/transformer and link circuit</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tFourQuadrantChopper", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EFourQuadrantChopper))]
    internal partial class TFourQuadrantChopper : IAAssemblyNameNumber, IAFourQuadrantChopper
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>number of assemblies per vehicle/unit</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("count")]
        public string Count { get; set; }
        
        /// <summary>
        /// <para>type of assembly as descriptive name</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("assemblyName")]
        public string AssemblyName { get; set; }
        
        /// <summary>
        /// <para>average phase angle phi of four-quadrant-chopper (in traction mode)</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-180", "180")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("meanPhi")]
        public decimal MeanPhiValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeanPhi-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MeanPhi property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MeanPhiValueSpecified { get; set; }
        
        /// <summary>
        /// <para>average phase angle phi of four-quadrant-chopper (in traction mode)</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> MeanPhi
        {
            get
            {
                if (this.MeanPhiValueSpecified)
                {
                    return this.MeanPhiValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MeanPhiValue = value.GetValueOrDefault();
                this.MeanPhiValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>average phase angle phi of four-quadrant-chopper in regeneration mode</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "-180", "180")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("meanPhiRegeneration")]
        public decimal MeanPhiRegenerationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeanPhiRegeneration-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MeanPhiRegeneration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MeanPhiRegenerationValueSpecified { get; set; }
        
        /// <summary>
        /// <para>average phase angle phi of four-quadrant-chopper in regeneration mode</para>
        /// <para>generic type for angle values measured in degree, allowing -180 ... +180</para>
        /// <para xml:lang="en">Minimum inclusive value: -180.</para>
        /// <para xml:lang="en">Maximum inclusive value: 180.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> MeanPhiRegeneration
        {
            get
            {
                if (this.MeanPhiRegenerationValueSpecified)
                {
                    return this.MeanPhiRegenerationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MeanPhiRegenerationValue = value.GetValueOrDefault();
                this.MeanPhiRegenerationValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>The four quadrant chopper mean efficiency in the range 0..1.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "1")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("meanEfficiency")]
        public decimal MeanEfficiencyValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MeanEfficiency-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MeanEfficiency property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MeanEfficiencyValueSpecified { get; set; }
        
        /// <summary>
        /// <para>The four quadrant chopper mean efficiency in the range 0..1.</para>
        /// <para>generic type for values only between 0 and 1, as efficiency or cosine phi.</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 1.</para>
        /// <para xml:lang="en">Total number of digits in fraction: 6.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> MeanEfficiency
        {
            get
            {
                if (this.MeanEfficiencyValueSpecified)
                {
                    return this.MeanEfficiencyValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MeanEfficiencyValue = value.GetValueOrDefault();
                this.MeanEfficiencyValueSpecified = value.HasValue;
            }
        }
    }
}
