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
    [System.Xml.Serialization.XmlTypeAttribute("tSwitchConnectionData", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TSwitchConnectionData : TConnectionData, IAConnectionData
    {
        
        [System.Xml.Serialization.XmlAttributeAttribute("course")]
        public string Course { get; set; }
        
        /// <summary>
        /// <para>generic type for radius values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("radius")]
        public decimal RadiusValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Radius-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Radius property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RadiusValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic type for radius values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> Radius
        {
            get
            {
                if (this.RadiusValueSpecified)
                {
                    return this.RadiusValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RadiusValue = value.GetValueOrDefault();
                this.RadiusValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("maxSpeed")]
        public decimal MaxSpeedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MaxSpeed-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaxSpeed property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaxSpeedValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> MaxSpeed
        {
            get
            {
                if (this.MaxSpeedValueSpecified)
                {
                    return this.MaxSpeedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaxSpeedValue = value.GetValueOrDefault();
                this.MaxSpeedValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>DEPRECATED: use short 'track' instead</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("branchDist")]
        public decimal BranchDistValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BranchDist-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the BranchDist property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool BranchDistValueSpecified { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED: use short 'track' instead</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> BranchDist
        {
            get
            {
                if (this.BranchDistValueSpecified)
                {
                    return this.BranchDistValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.BranchDistValue = value.GetValueOrDefault();
                this.BranchDistValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("orientation")]
        public string Orientation { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _passable = true;
        
        [System.ComponentModel.DefaultValueAttribute(true)]
        [System.Xml.Serialization.XmlAttributeAttribute("passable")]
        public bool Passable
        {
            get
            {
                return this._passable;
            }
            set
            {
                this._passable = value;
            }
        }
    }
}
