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
    [XmlTypeAttribute("eOcpPropOperational", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EOcpPropOperational : genericRailML.TOcpPropOperational
    {
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TOcpUptime> _uptime;
        
        [XmlElementAttribute("uptime", Order=0)]
        public Collection<genericRailML.TOcpUptime> Uptime
        {
            get
            {
                return this._uptime;
            }
            private set
            {
                this._uptime = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Uptime-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Uptime collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool UptimeSpecified
        {
            get
            {
                return (this.Uptime.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EOcpPropOperational" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EOcpPropOperational" /> class.</para>
        /// </summary>
        public EOcpPropOperational()
        {
            this._uptime = new Collection<genericRailML.TOcpUptime>();
        }
    }
}
