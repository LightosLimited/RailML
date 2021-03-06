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
    [XmlTypeAttribute("eTrainGroup", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class ETrainGroup : genericRailML.TTrainGroup
    {
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TElementRefInGroup> _trainRef;
        
        /// <summary>
        /// <para>reference to the trains included in a trainGroup; the group members could be ordered by a sequence attribute</para>
        /// </summary>
        [XmlElementAttribute("trainRef", Order=0)]
        public Collection<genericRailML.TElementRefInGroup> TrainRef
        {
            get
            {
                return this._trainRef;
            }
            private set
            {
                this._trainRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ETrainGroup" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ETrainGroup" /> class.</para>
        /// </summary>
        public ETrainGroup()
        {
            this._trainRef = new Collection<genericRailML.TElementRefInGroup>();
        }
    }
}
