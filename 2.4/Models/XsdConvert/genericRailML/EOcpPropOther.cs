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
    [XmlTypeAttribute("eOcpPropOther", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EOcpPropOther : genericRailML.TOcpPropOther
    {
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TOcpAdditionalName> _additionalName;
        
        /// <summary>
        /// <para>Deprecated for next major release, use "additionalName" in "ocp" instead.</para>
        /// </summary>
        [XmlElementAttribute("additionalName", Order=0)]
        public Collection<genericRailML.TOcpAdditionalName> AdditionalName
        {
            get
            {
                return this._additionalName;
            }
            private set
            {
                this._additionalName = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die AdditionalName-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the AdditionalName collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool AdditionalNameSpecified
        {
            get
            {
                return (this.AdditionalName.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EOcpPropOther" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EOcpPropOther" /> class.</para>
        /// </summary>
        public EOcpPropOther()
        {
            this._additionalName = new Collection<genericRailML.TOcpAdditionalName>();
        }
        
        /// <summary>
        /// <para>container for states of OCP; use this element to define the status of the OCP in terms of availability for operation</para>
        /// </summary>
        [XmlElementAttribute("states", Order=1)]
        public genericRailML.TStates States { get; set; }
    }
}
