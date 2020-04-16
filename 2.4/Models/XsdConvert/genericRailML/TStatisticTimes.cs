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
    [XmlTypeAttribute("tStatisticTimes", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TStatisticTimes : IAArrivalDepartureTimes, IAArrivalDepartureDelay, genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("arrival", DataType="time")]
        public System.DateTime ArrivalValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Arrival-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Arrival property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool ArrivalValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> Arrival
        {
            get
            {
                if (this.ArrivalValueSpecified)
                {
                    return this.ArrivalValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.ArrivalValue = value.GetValueOrDefault();
                this.ArrivalValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private string _arrivalDay = "0";
        
        [DefaultValueAttribute("0")]
        [XmlAttributeAttribute("arrivalDay")]
        public string ArrivalDay
        {
            get
            {
                return this._arrivalDay;
            }
            set
            {
                this._arrivalDay = value;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("departure", DataType="time")]
        public System.DateTime DepartureValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Departure-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Departure property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool DepartureValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> Departure
        {
            get
            {
                if (this.DepartureValueSpecified)
                {
                    return this.DepartureValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DepartureValue = value.GetValueOrDefault();
                this.DepartureValueSpecified = value.HasValue;
            }
        }
        
        [XmlIgnoreAttribute()]
        private string _departureDay = "0";
        
        [DefaultValueAttribute("0")]
        [XmlAttributeAttribute("departureDay")]
        public string DepartureDay
        {
            get
            {
                return this._departureDay;
            }
            set
            {
                this._departureDay = value;
            }
        }
        
        [XmlAttributeAttribute("arrivalDelay")]
        public string ArrivalDelay { get; set; }
        
        [XmlAttributeAttribute("departureDelay")]
        public string DepartureDelay { get; set; }
        
        [XmlAttributeAttribute("stopTime")]
        public string StopTime { get; set; }
    }
}
