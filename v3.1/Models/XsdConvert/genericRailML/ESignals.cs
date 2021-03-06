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
    [System.Xml.Serialization.XmlTypeAttribute("eSignals", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class ESignals
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TSignal> _signal;
        
        [System.Xml.Serialization.XmlElementAttribute("signal", Order=0)]
        public System.Collections.ObjectModel.Collection<genericRailML.TSignal> Signal
        {
            get
            {
                return this._signal;
            }
            private set
            {
                this._signal = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Signal-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Signal collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool SignalSpecified
        {
            get
            {
                return (this.Signal.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ESignals" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ESignals" /> class.</para>
        /// </summary>
        public ESignals()
        {
            this._signal = new System.Collections.ObjectModel.Collection<genericRailML.TSignal>();
            this._signalGroups = new System.Collections.ObjectModel.Collection<ESignalGroups>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ESignalGroups> _signalGroups;
        
        [System.Xml.Serialization.XmlElementAttribute("signalGroups", Order=1)]
        public System.Collections.ObjectModel.Collection<ESignalGroups> SignalGroups
        {
            get
            {
                return this._signalGroups;
            }
            private set
            {
                this._signalGroups = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die SignalGroups-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the SignalGroups collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool SignalGroupsSpecified
        {
            get
            {
                return (this.SignalGroups.Count != 0);
            }
        }
    }
}
