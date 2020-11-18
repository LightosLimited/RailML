//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace Models.DB
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("eTrainRadioChanges", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class ETrainRadioChanges
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TTrainRadioChange> _trainRadioChange;
        
        /// <summary>
        /// <para>start of section with certain train radio system installed at the infrastructure</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("trainRadioChange", Order=0)]
        public System.Collections.ObjectModel.Collection<TTrainRadioChange> TrainRadioChange
        {
            get
            {
                return this._trainRadioChange;
            }
            private set
            {
                this._trainRadioChange = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ETrainRadioChanges" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ETrainRadioChanges" /> class.</para>
        /// </summary>
        public ETrainRadioChanges()
        {
            this._trainRadioChange = new System.Collections.ObjectModel.Collection<TTrainRadioChange>();
        }
    }
}