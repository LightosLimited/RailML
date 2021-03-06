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
    [System.Xml.Serialization.XmlTypeAttribute("tTrainEngine", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TTrainEngine : IATrainEngine
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>formation whole mean acceleration in m/s^2</para>
        /// <para>generic type for acceleration values measured in meter per square second</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("trainMeanAcceleration")]
        public decimal TrainMeanAccelerationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainMeanAcceleration-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TrainMeanAcceleration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TrainMeanAccelerationValueSpecified { get; set; }
        
        /// <summary>
        /// <para>formation whole mean acceleration in m/s^2</para>
        /// <para>generic type for acceleration values measured in meter per square second</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TrainMeanAcceleration
        {
            get
            {
                if (this.TrainMeanAccelerationValueSpecified)
                {
                    return this.TrainMeanAccelerationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TrainMeanAccelerationValue = value.GetValueOrDefault();
                this.TrainMeanAccelerationValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>formation whole maximum acceleration in m/s^2</para>
        /// <para>generic type for acceleration values measured in meter per square second</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("trainMaxAcceleration")]
        public decimal TrainMaxAccelerationValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainMaxAcceleration-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TrainMaxAcceleration property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TrainMaxAccelerationValueSpecified { get; set; }
        
        /// <summary>
        /// <para>formation whole maximum acceleration in m/s^2</para>
        /// <para>generic type for acceleration values measured in meter per square second</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TrainMaxAcceleration
        {
            get
            {
                if (this.TrainMaxAccelerationValueSpecified)
                {
                    return this.TrainMaxAccelerationValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TrainMaxAccelerationValue = value.GetValueOrDefault();
                this.TrainMaxAccelerationValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>minimum time the train can maintain its speed before it must brake as flag for acceleration acceptance</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("trainMinTimeHoldSpeed")]
        public string TrainMinTimeHoldSpeed { get; set; }
    }
}
