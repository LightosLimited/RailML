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
    [System.Xml.Serialization.XmlTypeAttribute("tServiceSection", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TServiceSection : TBaseServiceSection
    {
        
        /// <summary>
        /// <para>reference to a parent service section for grouping service section parts together</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("parentServiceSectionRef")]
        public string ParentServiceSectionRef { get; set; }
        
        /// <summary>
        /// <para>defining the service section as being a ramp</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("ramp")]
        public bool RampValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Ramp-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Ramp property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool RampValueSpecified { get; set; }
        
        /// <summary>
        /// <para>defining the service section as being a ramp</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Ramp
        {
            get
            {
                if (this.RampValueSpecified)
                {
                    return this.RampValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.RampValue = value.GetValueOrDefault();
                this.RampValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>defining the service section as being a maintenance area</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("maintenance")]
        public bool MaintenanceValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Maintenance-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Maintenance property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaintenanceValueSpecified { get; set; }
        
        /// <summary>
        /// <para>defining the service section as being a maintenance area</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Maintenance
        {
            get
            {
                if (this.MaintenanceValueSpecified)
                {
                    return this.MaintenanceValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaintenanceValue = value.GetValueOrDefault();
                this.MaintenanceValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>defining the service section as being equipped with loading facilities</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("loadingFacility")]
        public bool LoadingFacilityValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LoadingFacility-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the LoadingFacility property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool LoadingFacilityValueSpecified { get; set; }
        
        /// <summary>
        /// <para>defining the service section as being equipped with loading facilities</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> LoadingFacility
        {
            get
            {
                if (this.LoadingFacilityValueSpecified)
                {
                    return this.LoadingFacilityValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.LoadingFacilityValue = value.GetValueOrDefault();
                this.LoadingFacilityValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>defining the service section as being a cleaning area</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("cleaning")]
        public bool CleaningValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Cleaning-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Cleaning property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool CleaningValueSpecified { get; set; }
        
        /// <summary>
        /// <para>defining the service section as being a cleaning area</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Cleaning
        {
            get
            {
                if (this.CleaningValueSpecified)
                {
                    return this.CleaningValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.CleaningValue = value.GetValueOrDefault();
                this.CleaningValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>defining the service section as being a fueling area</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("fueling")]
        public bool FuelingValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Fueling-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Fueling property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool FuelingValueSpecified { get; set; }
        
        /// <summary>
        /// <para>defining the service section as being a fueling area</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Fueling
        {
            get
            {
                if (this.FuelingValueSpecified)
                {
                    return this.FuelingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.FuelingValue = value.GetValueOrDefault();
                this.FuelingValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>defining the service section as being a parking area</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("parking")]
        public bool ParkingValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Parking-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Parking property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool ParkingValueSpecified { get; set; }
        
        /// <summary>
        /// <para>defining the service section as being a parking area</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Parking
        {
            get
            {
                if (this.ParkingValueSpecified)
                {
                    return this.ParkingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ParkingValue = value.GetValueOrDefault();
                this.ParkingValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>defining the service section as being a preheating area</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("preheating")]
        public bool PreheatingValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Preheating-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Preheating property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool PreheatingValueSpecified { get; set; }
        
        /// <summary>
        /// <para>defining the service section as being a preheating area</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Preheating
        {
            get
            {
                if (this.PreheatingValueSpecified)
                {
                    return this.PreheatingValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.PreheatingValue = value.GetValueOrDefault();
                this.PreheatingValueSpecified = value.HasValue;
            }
        }
    }
}
