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
    [XmlTypeAttribute("eCrossing", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class ECrossing : genericRailML.TCrossing
    {
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TSwitchConnectionData> _connection;
        
        [XmlElementAttribute("connection", Order=0)]
        public Collection<genericRailML.TSwitchConnectionData> Connection
        {
            get
            {
                return this._connection;
            }
            private set
            {
                this._connection = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ECrossing" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ECrossing" /> class.</para>
        /// </summary>
        public ECrossing()
        {
            this._connection = new Collection<genericRailML.TSwitchConnectionData>();
        }
    }
}
