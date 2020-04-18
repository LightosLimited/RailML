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
    [XmlTypeAttribute("tState", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(TStateWithLength))]
    internal partial class TState : IAPeriodTimeSpan, genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<System.Xml.Linq.XElement> _any;
        
        /// <summary>
        /// <para>provide an extension point for non-railML elements in foreign namespace</para>
        /// </summary>
        [XmlAnyElementAttribute(Order=0)]
        [NotMappedAttribute()]
        public Collection<System.Xml.Linq.XElement> Any
        {
            get
            {
                return this._any;
            }
            private set
            {
                this._any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Any-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool AnySpecified
        {
            get
            {
                return (this.Any.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TState" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TState" /> class.</para>
        /// </summary>
        public TState()
        {
            this._any = new Collection<System.Xml.Linq.XElement>();
        }
        
        /// <summary>
        /// <para>This attribute is 'true' if the infrastructure piece is somehow disabled.</para>
        /// </summary>
        [XmlAttributeAttribute("disabled")]
        public bool Disabled { get; set; }
        
        /// <summary>
        /// <para>defines the status of the infrastructure element from perspective of its availability</para>
        /// </summary>
        [XmlAttributeAttribute("status")]
        public string Status { get; set; }
        
        /// <summary>
        /// <para>The temporal frame of the 'state' should be defined in the 'timetable' part of the railML file, using the 'operatingPeriod' element.</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [XmlAttributeAttribute("operatingPeriodRef")]
        public string OperatingPeriodRef { get; set; }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("startTime", DataType="time")]
        public System.DateTime StartTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StartTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StartTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StartTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> StartTime
        {
            get
            {
                if (this.StartTimeValueSpecified)
                {
                    return this.StartTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StartTimeValue = value.GetValueOrDefault();
                this.StartTimeValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("endTime", DataType="time")]
        public System.DateTime EndTimeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EndTime-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EndTime property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EndTimeValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> EndTime
        {
            get
            {
                if (this.EndTimeValueSpecified)
                {
                    return this.EndTimeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EndTimeValue = value.GetValueOrDefault();
                this.EndTimeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>The number of midnight overruns over which non-availability persists.</para>
        /// </summary>
        [XmlAttributeAttribute("endDayOffset")]
        public string EndDayOffset { get; set; }
        
        /// <summary>
        /// <para>This is to further explain the 'state' definition.</para>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("remarks")]
        public string Remarks { get; set; }
    }
}