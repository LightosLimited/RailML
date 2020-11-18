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
    
    
    /// <summary>
    /// <para>generic base type, used for inheritance of many railML types</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("tOcpWithIDAndName", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EOcp))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TOperationControlPoint))]
    internal partial class TOcpWithIDAndName : genericRailML.TAdditionalName
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<TAdditionalOcpName> _additionalName;
        
        /// <summary>
        /// <para>additional names and its according descriptions to be provided in other languages, dialects, encodings...</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("additionalName", Order=0)]
        public System.Collections.ObjectModel.Collection<TAdditionalOcpName> AdditionalName
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool AdditionalNameSpecified
        {
            get
            {
                return (this.AdditionalName.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TOcpWithIDAndName" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TOcpWithIDAndName" /> class.</para>
        /// </summary>
        public TOcpWithIDAndName()
        {
            this._additionalName = new System.Collections.ObjectModel.Collection<TAdditionalOcpName>();
            this._any = new System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement>();
        }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<System.Xml.Linq.XElement> _any;
        
        /// <summary>
        /// <para>provide an extension point for non-railML elements in foreign namespace</para>
        /// </summary>
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
        /// <para>XML-file-wide unique identity is required for later referencing that element</para>
        /// <para>an XML-side constrained bi-unique identity; unique across an XML file including its outsourced components (xi:include mechanism); white spaces not allowed</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id { get; set; }
        
        /// <summary>
        /// <para>for typical, specific abbreviations, used in different systems with the same understanding</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("code")]
        public string Code { get; set; }
        
        /// <summary>
        /// <para>type of the ocp name</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }
    }
}