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
    [System.Xml.Serialization.XmlTypeAttribute("eTimetablePeriods", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class ETimetablePeriods
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<ETimetablePeriod> _timetablePeriod;
        
        [System.Xml.Serialization.XmlElementAttribute("timetablePeriod", Order=0)]
        public System.Collections.ObjectModel.Collection<ETimetablePeriod> TimetablePeriod
        {
            get
            {
                return this._timetablePeriod;
            }
            private set
            {
                this._timetablePeriod = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ETimetablePeriods" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ETimetablePeriods" /> class.</para>
        /// </summary>
        public ETimetablePeriods()
        {
            this._timetablePeriod = new System.Collections.ObjectModel.Collection<ETimetablePeriod>();
        }
    }
}
