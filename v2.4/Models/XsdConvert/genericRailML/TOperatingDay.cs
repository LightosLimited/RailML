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
    [XmlTypeAttribute("tOperatingDay", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EOperatingDay))]
    internal partial class TOperatingDay : IAOperatingCode, genericRailML.IATimePeriod, genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<System.Xml.Linq.XElement> _any;
        
        /// <summary>
        /// <para>provide an extension point for non-railML elements in foreign namespace</para>
        /// </summary>
        [XmlAnyElementAttribute(Order=0)]
        [NotMappedAttribute()]
        public Collection<System.Xml.Linq.XElement> Any
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
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool AnySpecified
        {
            get
            {
                return (this.Any.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TOperatingDay" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TOperatingDay" /> class.</para>
        /// </summary>
        public TOperatingDay()
        {
            this._any = new Collection<System.Xml.Linq.XElement>();
        }
        
        /// <summary>
        /// <para xml:lang="en">Pattern: [0-1]{7}.</para>
        /// </summary>
        [RegularExpressionAttribute("[0-1]{7}")]
        [XmlAttributeAttribute("operatingCode")]
        public string OperatingCode { get; set; }
        
        /// <summary>
        /// <para>needed for "runs Monday to Friday and additionally Sunday on request"</para>
        /// </summary>
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("onRequest")]
        public bool OnRequestValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OnRequest-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the OnRequest property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool OnRequestValueSpecified { get; set; }
        
        /// <summary>
        /// <para>needed for "runs Monday to Friday and additionally Sunday on request"</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        public System.Nullable<bool> OnRequest
        {
            get
            {
                if (this.OnRequestValueSpecified)
                {
                    return this.OnRequestValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnRequestValue = value.GetValueOrDefault();
                this.OnRequestValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("startDate", DataType="date")]
        public System.DateTime StartDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StartDate-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the StartDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool StartDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> StartDate
        {
            get
            {
                if (this.StartDateValueSpecified)
                {
                    return this.StartDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.StartDateValue = value.GetValueOrDefault();
                this.StartDateValueSpecified = value.HasValue;
            }
        }
        
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        [NotMappedAttribute()]
        [XmlAttributeAttribute("endDate", DataType="date")]
        public System.DateTime EndDateValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die EndDate-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the EndDate property is specified.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        [EditorBrowsableAttribute(EditorBrowsableState.Never)]
        public bool EndDateValueSpecified { get; set; }
        
        [XmlIgnoreAttribute()]
        public System.Nullable<System.DateTime> EndDate
        {
            get
            {
                if (this.EndDateValueSpecified)
                {
                    return this.EndDateValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.EndDateValue = value.GetValueOrDefault();
                this.EndDateValueSpecified = value.HasValue;
            }
        }
    }
}
