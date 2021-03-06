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
    [System.Xml.Serialization.XmlTypeAttribute("eGeneralInfraAttribute", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EGeneralInfraAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("attributes", Order=0)]
        public EAttributes Attributes { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> _any;
        
        [System.Xml.Serialization.XmlAnyElementAttribute(Order=1)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> Any
        {
            get
            {
                return this._any;
            }
            private set
            {
                this._any = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die Any-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the Any collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool AnySpecified
        {
            get
            {
                return (this.Any.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EGeneralInfraAttribute" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EGeneralInfraAttribute" /> class.</para>
        /// </summary>
        public EGeneralInfraAttribute()
        {
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement>();
        }
    }
}
