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
    [XmlTypeAttribute("eClassification", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EClassification
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        /// <summary>
        /// <para>manufacturer data related to the vehicle</para>
        /// </summary>
        [XmlElementAttribute("manufacturer", Order=0)]
        public genericRailML.TManufacturer Manufacturer { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<EOperator> _operator;
        
        /// <summary>
        /// <para>general operator specific vehicle data</para>
        /// </summary>
        [XmlElementAttribute("operator", Order=1)]
        public Collection<EOperator> Operator
        {
            get
            {
                return this._operator;
            }
            private set
            {
                this._operator = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Operator-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Operator collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool OperatorSpecified
        {
            get
            {
                return (this.Operator.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EClassification" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EClassification" /> class.</para>
        /// </summary>
        public EClassification()
        {
            this._operator = new Collection<EOperator>();
        }
    }
}
