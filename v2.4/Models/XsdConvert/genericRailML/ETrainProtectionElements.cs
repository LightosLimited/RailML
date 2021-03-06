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
    [XmlTypeAttribute("eTrainProtectionElements", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class ETrainProtectionElements
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TTrainProtectionElement> _trainProtectionElement;
        
        [XmlElementAttribute("trainProtectionElement", Order=0)]
        public Collection<genericRailML.TTrainProtectionElement> TrainProtectionElement
        {
            get
            {
                return this._trainProtectionElement;
            }
            private set
            {
                this._trainProtectionElement = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainProtectionElement-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TrainProtectionElement collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool TrainProtectionElementSpecified
        {
            get
            {
                return (this.TrainProtectionElement.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ETrainProtectionElements" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ETrainProtectionElements" /> class.</para>
        /// </summary>
        public ETrainProtectionElements()
        {
            this._trainProtectionElement = new Collection<genericRailML.TTrainProtectionElement>();
            this._trainProtectionElementGroup = new Collection<genericRailML.TTrainProtectionElementGroup>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TTrainProtectionElementGroup> _trainProtectionElementGroup;
        
        [XmlElementAttribute("trainProtectionElementGroup", Order=1)]
        public Collection<genericRailML.TTrainProtectionElementGroup> TrainProtectionElementGroup
        {
            get
            {
                return this._trainProtectionElementGroup;
            }
            private set
            {
                this._trainProtectionElementGroup = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrainProtectionElementGroup-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TrainProtectionElementGroup collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool TrainProtectionElementGroupSpecified
        {
            get
            {
                return (this.TrainProtectionElementGroup.Count != 0);
            }
        }
    }
}
