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
    [System.Xml.Serialization.XmlTypeAttribute("tSignal", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TSignal : TRuleCodeElement, IASignal, IAOcpRef
    {
        
        /// <summary>
        /// <para>sub-element for defining a speed signal or panel</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("speed", Order=0)]
        public TSignalSpeed Speed { get; set; }
        
        /// <summary>
        /// <para>sub-element for defining an ETCS panel</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("etcs", Order=1)]
        public TSignalEtcs Etcs { get; set; }
        
        /// <summary>
        /// <para>sub-element for defining a level crossing signal or panel</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("levelCrossing", Order=2)]
        public TSignalLevelCrossing LevelCrossing { get; set; }
        
        /// <summary>
        /// <para>sub-element for defining a train radio signal or panel</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainRadio", Order=3)]
        public TSignalTrainRadio TrainRadio { get; set; }
        
        /// <summary>
        /// <para>sub-element for defining a catenary signal or panel</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("catenary", Order=4)]
        public TSignalCatenary Catenary { get; set; }
        
        /// <summary>
        /// <para>sub-element for defining a line signal or panel</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("line", Order=5)]
        public TSignalLine Line { get; set; }
        
        /// <summary>
        /// <para>sub-element for defining a mileage signpost</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("milepost", Order=6)]
        public TSignalMilepost Milepost { get; set; }
        
        /// <summary>
        /// <para>sub-element for defining a braking signal or panel</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("braking", Order=7)]
        public TSignalBraking Braking { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference> _trainProtectionElementGroupRef;
        
        /// <summary>
        /// <para>sub-element for a reference to a trainProtectionElementGroup, which is connected to the signal's aspect</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainProtectionElementGroupRef", Order=8)]
        public System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference> TrainProtectionElementGroupRef
        {
            get
            {
                return this._trainProtectionElementGroupRef;
            }
            private set
            {
                this._trainProtectionElementGroupRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainProtectionElementGroupRef-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TrainProtectionElementGroupRef collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool TrainProtectionElementGroupRefSpecified
        {
            get
            {
                return (this.TrainProtectionElementGroupRef.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TSignal" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TSignal" /> class.</para>
        /// </summary>
        public TSignal()
        {
            this._trainProtectionElementGroupRef = new System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference>();
            this._baliseGroupRef = new System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference> _baliseGroupRef;
        
        /// <summary>
        /// <para>sub-element for a reference to a baliseGroup, which is connected to the signal's aspect</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("baliseGroupRef", Order=9)]
        public System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference> BaliseGroupRef
        {
            get
            {
                return this._baliseGroupRef;
            }
            private set
            {
                this._baliseGroupRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BaliseGroupRef-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the BaliseGroupRef collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool BaliseGroupRefSpecified
        {
            get
            {
                return (this.BaliseGroupRef.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("sight")]
        public decimal SightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Sight-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Sight property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> Sight
        {
            get
            {
                if (this.SightValueSpecified)
                {
                    return this.SightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SightValue = value.GetValueOrDefault();
                this.SightValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }
        
        [System.Xml.Serialization.XmlAttributeAttribute("function")]
        public string Function { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED since it is not needed and not used.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("sigSystem")]
        public string SigSystem { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED: use attribute 'switchable' in sub-elements instead</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("switchable")]
        public bool SwitchableValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Switchable-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Switchable property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool SwitchableValueSpecified { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED: use attribute 'switchable' in sub-elements instead</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Switchable
        {
            get
            {
                if (this.SwitchableValueSpecified)
                {
                    return this.SwitchableValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.SwitchableValue = value.GetValueOrDefault();
                this.SwitchableValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("maskableRoute")]
        public bool MaskableRouteValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MaskableRoute-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaskableRoute property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaskableRouteValueSpecified { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> MaskableRoute
        {
            get
            {
                if (this.MaskableRouteValueSpecified)
                {
                    return this.MaskableRouteValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaskableRouteValue = value.GetValueOrDefault();
                this.MaskableRouteValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("maskableATC")]
        public bool MaskableATCValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die MaskableATC-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the MaskableATC property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool MaskableATCValueSpecified { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> MaskableATC
        {
            get
            {
                if (this.MaskableATCValueSpecified)
                {
                    return this.MaskableATCValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.MaskableATCValue = value.GetValueOrDefault();
                this.MaskableATCValueSpecified = value.HasValue;
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private bool _virtual = false;
        
        [System.ComponentModel.DefaultValueAttribute(false)]
        [System.Xml.Serialization.XmlAttributeAttribute("virtual")]
        public bool Virtual
        {
            get
            {
                return this._virtual;
            }
            set
            {
                this._virtual = value;
            }
        }
        
        /// <summary>
        /// <para>DEPRECATED: use attribute 'controllerRef' instead</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("signalBoxOcpRef")]
        public string SignalBoxOcpRef { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED: use attribute 'ocpStationRef' instead</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("stationOcpRef")]
        public string StationOcpRef { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("distNearestDangerPoint")]
        public decimal DistNearestDangerPointValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die DistNearestDangerPoint-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the DistNearestDangerPoint property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool DistNearestDangerPointValueSpecified { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> DistNearestDangerPoint
        {
            get
            {
                if (this.DistNearestDangerPointValueSpecified)
                {
                    return this.DistNearestDangerPointValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.DistNearestDangerPointValue = value.GetValueOrDefault();
                this.DistNearestDangerPointValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("trackDist")]
        public decimal TrackDistValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrackDist-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TrackDist property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TrackDistValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TrackDist
        {
            get
            {
                if (this.TrackDistValueSpecified)
                {
                    return this.TrackDistValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TrackDistValue = value.GetValueOrDefault();
                this.TrackDistValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("height")]
        public decimal HeightValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Height-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Height property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool HeightValueSpecified { get; set; }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> Height
        {
            get
            {
                if (this.HeightValueSpecified)
                {
                    return this.HeightValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.HeightValue = value.GetValueOrDefault();
                this.HeightValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>reference on ocp element, e.g. station</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ocpStationRef")]
        public string OcpStationRef { get; set; }
        
        /// <summary>
        /// <para>reference on controller element, e.g. interlocking</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("controllerRef")]
        public string ControllerRef { get; set; }
    }
}
