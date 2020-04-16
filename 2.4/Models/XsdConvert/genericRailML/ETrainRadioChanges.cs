//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    [XmlTypeAttribute("eTrainRadioChanges", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class ETrainRadioChanges
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TTrainRadioChange> _trainRadioChange;
        
        /// <summary>
        /// <para>start of section with certain train radio system installed at the infrastructure</para>
        /// </summary>
        [XmlElementAttribute("trainRadioChange", Order=0)]
        public Collection<genericRailML.TTrainRadioChange> TrainRadioChange
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
            this._trainRadioChange = new Collection<genericRailML.TTrainRadioChange>();
        }
    }
}
