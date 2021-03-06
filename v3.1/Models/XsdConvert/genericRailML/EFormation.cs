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
    /// <para>data for train composition or vehicle formation</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("eFormation", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EFormation : genericRailML.TFormation
    {
        
        /// <summary>
        /// <para>car order for a formation</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainOrder", Order=0)]
        public ETrainOrder TrainOrder { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference> _categoryRef;
        
        /// <summary>
        /// <para>reference to train categories in TimeTable part, e.g. ltd. Express, the formation can run as in service</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("categoryRef", Order=1)]
        public System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference> CategoryRef
        {
            get
            {
                return this._categoryRef;
            }
            private set
            {
                this._categoryRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die CategoryRef-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the CategoryRef collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool CategoryRefSpecified
        {
            get
            {
                return (this.CategoryRef.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EFormation" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EFormation" /> class.</para>
        /// </summary>
        public EFormation()
        {
            this._categoryRef = new System.Collections.ObjectModel.Collection<genericRailML.TElementWithReference>();
            this._trainBrakeOperation = new System.Collections.ObjectModel.Collection<genericRailML.TBasicBrakeOperation>();
            this._speedProfileRef = new System.Collections.ObjectModel.Collection<genericRailML.TSpeedProfileRefRS>();
            this._technicalStopActivity = new System.Collections.ObjectModel.Collection<genericRailML.TTechnicalStopActivity>();
        }
        
        /// <summary>
        /// <para>acceleration value for whole formation</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainEngine", Order=2)]
        public genericRailML.TTrainEngine TrainEngine { get; set; }
        
        /// <summary>
        /// <para>for whole formation deceleration</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainBrakes", Order=3)]
        public genericRailML.TBasicBrakeType TrainBrakes { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TBasicBrakeOperation> _trainBrakeOperation;
        
        /// <summary>
        /// <para>operational braking rules according to specific supervision regime for entire formation</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainBrakeOperation", Order=4)]
        public System.Collections.ObjectModel.Collection<genericRailML.TBasicBrakeOperation> TrainBrakeOperation
        {
            get
            {
                return this._trainBrakeOperation;
            }
            private set
            {
                this._trainBrakeOperation = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainBrakeOperation-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TrainBrakeOperation collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool TrainBrakeOperationSpecified
        {
            get
            {
                return (this.TrainBrakeOperation.Count != 0);
            }
        }
        
        /// <summary>
        /// <para>mechanical train resistance vs. speed</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainResistance", Order=5)]
        public genericRailML.TTrainResistance TrainResistance { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TSpeedProfileRefRS> _speedProfileRef;
        
        /// <summary>
        /// <para>reference to permissible speed profiles for entire formation</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("speedProfileRef", Order=6)]
        public System.Collections.ObjectModel.Collection<genericRailML.TSpeedProfileRefRS> SpeedProfileRef
        {
            get
            {
                return this._speedProfileRef;
            }
            private set
            {
                this._speedProfileRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SpeedProfileRef-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SpeedProfileRef collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool SpeedProfileRefSpecified
        {
            get
            {
                return (this.SpeedProfileRef.Count != 0);
            }
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TTechnicalStopActivity> _technicalStopActivity;
        
        /// <summary>
        /// <para>list of stop activities with their related technical times</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("technicalStopActivity", Order=7)]
        public System.Collections.ObjectModel.Collection<genericRailML.TTechnicalStopActivity> TechnicalStopActivity
        {
            get
            {
                return this._technicalStopActivity;
            }
            private set
            {
                this._technicalStopActivity = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TechnicalStopActivity-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TechnicalStopActivity collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool TechnicalStopActivitySpecified
        {
            get
            {
                return (this.TechnicalStopActivity.Count != 0);
            }
        }
    }
}
