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
    [XmlTypeAttribute("eGeneralInfraAttributes", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EGeneralInfraAttributes
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<EGeneralInfraAttribute> _generalInfraAttribute;
        
        [XmlElementAttribute("generalInfraAttribute", Order=0)]
        public Collection<EGeneralInfraAttribute> GeneralInfraAttribute
        {
            get
            {
                return this._generalInfraAttribute;
            }
            private set
            {
                this._generalInfraAttribute = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die GeneralInfraAttribute-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the GeneralInfraAttribute collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool GeneralInfraAttributeSpecified
        {
            get
            {
                return (this.GeneralInfraAttribute.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EGeneralInfraAttributes" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EGeneralInfraAttributes" /> class.</para>
        /// </summary>
        public EGeneralInfraAttributes()
        {
            this._generalInfraAttribute = new Collection<EGeneralInfraAttribute>();
        }
    }
}
