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
    /// <summary>
    /// <para>description of any service provided by the passenger car(part)</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tService", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TService : IAService
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("name")]
        public string Name { get; set; }
        
        /// <summary>
        /// <para>Code list for the special services based on the directory of passenger code lists for the ERA technical documents used in TAP TSI (B.4.7161)</para>
        /// <para>Values are outlined in the type7161CodeList (http://www.era.europa.eu/Document-Register/Documents/ERA_TAP_Passenger_Code_List_1.3.1.xsd)</para>
        /// <para xml:lang="en">Maximum length: 3.</para>
        /// </summary>
        [MaxLengthAttribute(3)]
        [XmlAttributeAttribute("tapTsiType7161Code")]
        public string TapTsiType7161Code { get; set; }
        
        /// <summary>
        /// <para>count="0" means: there is not such a service</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        [XmlAttributeAttribute("count")]
        public string Count { get; set; }
        
        /// <summary>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("description")]
        public string Description { get; set; }
        
        /// <summary>
        /// <para>generic decimal value for additional information of the service, meaning should be clarified by its "description"</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("value")]
        public decimal ValueValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Value-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Value property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ValueValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic decimal value for additional information of the service, meaning should be clarified by its "description"</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<decimal> Value
        {
            get
            {
                if (this.ValueValueSpecified)
                {
                    return this.ValueValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ValueValue = value.GetValueOrDefault();
                this.ValueValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>list of common service types</para>
        /// </summary>
        [XmlAttributeAttribute("type")]
        public string Type { get; set; }
    }
}