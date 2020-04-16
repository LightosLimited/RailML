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
    [XmlTypeAttribute("tSpeedChange", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class TSpeedChange : TStrictOrientedElement, IASpeed
    {
        
        /// <summary>
        /// <para>DEPRECATED. Use the new attribute etcsTrainCategory instead.</para>
        /// <para>generic type for category names of trains; allowing digits, letters and white spaces; length not limited</para>
        /// </summary>
        [XmlAttributeAttribute("trainCategory")]
        public string TrainCategory { get; set; }
        
        /// <summary>
        /// <para>the international train category number as specified on page 38 in ERA_ERTMS_040001 "Assignment of values to ETCS variables" v1.9 from 10/07/12</para>
        /// <para>the international train category number as specified on page 38 in ERA_ERTMS_040001 "Assignment of values to ETCS variables" v1.9 from 10/07/12</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 15.</para>
        /// </summary>
        [RangeAttribute(typeof(decimal), "0", "15")]
        [XmlAttributeAttribute("etcsTrainCategory")]
        public string EtcsTrainCategory { get; set; }
        
        /// <summary>
        /// <para>reference to a speedProfile</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [XmlAttributeAttribute("profileRef")]
        public string ProfileRef { get; set; }
        
        [XmlAttributeAttribute("status")]
        public string Status { get; set; }
        
        /// <summary>
        /// <para>maximum allowed speed in km/h</para>
        /// </summary>
        [XmlAttributeAttribute("vMax")]
        public string VMax { get; set; }
        
        /// <summary>
        /// <para>Reference to the part of the train from where on the speed change is valid. Normally, a speed restriction that is higher than the train's current speed will be valid when the end of the train has passed the speed change while a speed restriction that is lower than the train's current speed will be valid already when the head of train passes the speedChange.</para>
        /// <para>If the attribute is not given, it means that the information is not known.</para>
        /// </summary>
        [XmlAttributeAttribute("trainRelation")]
        public string TrainRelation { get; set; }
        
        /// <summary>
        /// <para>specifying the speedChange as a mandatory stop point, e.g. in front of a level crossing</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("mandatoryStop")]
        public bool MandatoryStopValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MandatoryStop-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MandatoryStop property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool MandatoryStopValueSpecified { get; set; }
        
        /// <summary>
        /// <para>specifying the speedChange as a mandatory stop point, e.g. in front of a level crossing</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> MandatoryStop
        {
            get
            {
                if (this.MandatoryStopValueSpecified)
                {
                    return this.MandatoryStopValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MandatoryStopValue = value.GetValueOrDefault();
                this.MandatoryStopValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>indicates whether the speed aspect is shown next to the track by a signal or panel (true) or only in the "driver's timetable" (false)</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("signalised")]
        public bool SignalisedValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Signalised-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Signalised property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool SignalisedValueSpecified { get; set; }
        
        /// <summary>
        /// <para>indicates whether the speed aspect is shown next to the track by a signal or panel (true) or only in the "driver's timetable" (false)</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> Signalised
        {
            get
            {
                if (this.SignalisedValueSpecified)
                {
                    return this.SignalisedValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SignalisedValue = value.GetValueOrDefault();
                this.SignalisedValueSpecified = value.HasValue;
            }
        }
    }
}
