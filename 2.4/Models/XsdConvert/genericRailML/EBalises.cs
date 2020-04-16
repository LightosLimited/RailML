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
    [XmlTypeAttribute("eBalises", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EBalises
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TBalise> _balise;
        
        [XmlElementAttribute("balise", Order=0)]
        public Collection<genericRailML.TBalise> Balise
        {
            get
            {
                return this._balise;
            }
            private set
            {
                this._balise = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EBalises" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EBalises" /> class.</para>
        /// </summary>
        public EBalises()
        {
            this._balise = new Collection<genericRailML.TBalise>();
            this._baliseGroup = new Collection<genericRailML.TBaliseGroup>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TBaliseGroup> _baliseGroup;
        
        [XmlElementAttribute("baliseGroup", Order=1)]
        public Collection<genericRailML.TBaliseGroup> BaliseGroup
        {
            get
            {
                return this._baliseGroup;
            }
            private set
            {
                this._baliseGroup = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die BaliseGroup-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the BaliseGroup collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool BaliseGroupSpecified
        {
            get
            {
                return (this.BaliseGroup.Count != 0);
            }
        }
    }
}
