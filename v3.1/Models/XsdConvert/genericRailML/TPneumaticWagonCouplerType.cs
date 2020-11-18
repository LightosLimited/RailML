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
    /// <para>data of available pneumatic couplers between wagons</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tPneumaticWagonCouplerType", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EPneumaticCoupler))]
    internal partial class TPneumaticWagonCouplerType : IAPneumaticWagonCoupler
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>basic position of the pneumatic wagon coupler (front/rear/both)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("positionOnCarEnd")]
        public TEndPositionType PositionOnCarEnd { get; set; }
        
        /// <summary>
        /// <para>the function the pneumatic coupler is used for</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("couplerFunction")]
        public string CouplerFunction { get; set; }
        
        /// <summary>
        /// <para>flag, whether the pneumatic coupler is integrated in the mechanical coupler and coupled automatically</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("integratedOnMechanicalCoupler")]
        public bool IntegratedOnMechanicalCouplerValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die IntegratedOnMechanicalCoupler-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the IntegratedOnMechanicalCoupler property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool IntegratedOnMechanicalCouplerValueSpecified { get; set; }
        
        /// <summary>
        /// <para>flag, whether the pneumatic coupler is integrated in the mechanical coupler and coupled automatically</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> IntegratedOnMechanicalCoupler
        {
            get
            {
                if (this.IntegratedOnMechanicalCouplerValueSpecified)
                {
                    return this.IntegratedOnMechanicalCouplerValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.IntegratedOnMechanicalCouplerValue = value.GetValueOrDefault();
                this.IntegratedOnMechanicalCouplerValueSpecified = value.HasValue;
            }
        }
    }
}