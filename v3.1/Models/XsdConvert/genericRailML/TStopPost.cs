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
    [System.Xml.Serialization.XmlTypeAttribute("tStopPost", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TStopPost : TRuleCodeElement, IAStopPost, genericRailML.IAnyAttribute
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TValidForMovements> _validForMovements;
        
        /// <summary>
        /// <para>specification of the train types for which the stop post is relevant</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("validForMovements", Order=0)]
        public System.Collections.ObjectModel.Collection<TValidForMovements> ValidForMovements
        {
            get
            {
                return this._validForMovements;
            }
            private set
            {
                this._validForMovements = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ValidForMovements-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ValidForMovements collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ValidForMovementsSpecified
        {
            get
            {
                return (this.ValidForMovements.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TStopPost" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TStopPost" /> class.</para>
        /// </summary>
        public TStopPost()
        {
            this._validForMovements = new System.Collections.ObjectModel.Collection<TValidForMovements>();
            this._signalRef = new System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference> _signalRef;
        
        /// <summary>
        /// <para>reference to a (main) signal that is valid for a train waiting at the stop post</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("signalRef", Order=1)]
        public System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference> SignalRef
        {
            get
            {
                return this._signalRef;
            }
            private set
            {
                this._signalRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SignalRef-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SignalRef collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool SignalRefSpecified
        {
            get
            {
                return (this.SignalRef.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>Reference to the part of the train from where on the stop post is valid. Normally, a stop post relates to the head of the train.</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("trainRelation")]
        public string TrainRelation { get; set; }
        
        /// <summary>
        /// <para>reference to a platform edge for which the stop post is relevant</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("platformEdgeRef")]
        public string PlatformEdgeRef { get; set; }
        
        /// <summary>
        /// <para>set this value if the stop post is only valid for trains with a certain train length</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("trainLength")]
        public decimal TrainLengthValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainLength-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TrainLength property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TrainLengthValueSpecified { get; set; }
        
        /// <summary>
        /// <para>set this value if the stop post is only valid for trains with a certain train length</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<decimal> TrainLength
        {
            get
            {
                if (this.TrainLengthValueSpecified)
                {
                    return this.TrainLengthValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TrainLengthValue = value.GetValueOrDefault();
                this.TrainLengthValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>set this value if the stop post is only valid for trains with a certain number of axles</para>
        /// <para>generic type for counters (e.g. order number of a vehicle in an formation), starting with '1'</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("axleCount")]
        public string AxleCount { get; set; }
        
        /// <summary>
        /// <para>set this value if the stop post is only valid for trains with a certain number of wagons</para>
        /// <para>generic type for counters (e.g. order number of a vehicle in an formation), starting with '1'</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("wagonCount")]
        public string WagonCount { get; set; }
        
        /// <summary>
        /// <para>set this value if the stop post is only valid for trains fulfilling a certain verbal constraint</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("verbalConstraints")]
        public string VerbalConstraints { get; set; }
        
        /// <summary>
        /// <para>marks a stop post being virtual if there is no physical representation along the track</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("virtual")]
        public bool VirtualValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Virtual-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the Virtual property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool VirtualValueSpecified { get; set; }
        
        /// <summary>
        /// <para>marks a stop post being virtual if there is no physical representation along the track</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<bool> Virtual
        {
            get
            {
                if (this.VirtualValueSpecified)
                {
                    return this.VirtualValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.VirtualValue = value.GetValueOrDefault();
                this.VirtualValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>reference to an OCP, which the stop post belongs to</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("ocpRef")]
        public string OcpRef { get; set; }
    }
}
