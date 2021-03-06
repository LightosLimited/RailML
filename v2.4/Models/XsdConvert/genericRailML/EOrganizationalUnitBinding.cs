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
    [XmlTypeAttribute("eOrganizationalUnitBinding", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EOrganizationalUnitBinding
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlElementAttribute("vehicleOperator", Order=0)]
        public genericRailML.TElementWithReference VehicleOperator { get; set; }
        
        [XmlElementAttribute("customer", Order=1)]
        public genericRailML.TElementWithReference Customer { get; set; }
        
        [XmlElementAttribute("railwayUndertaking", Order=2)]
        public genericRailML.TElementWithReference RailwayUndertaking { get; set; }
        
        [XmlElementAttribute("operationalUndertaking", Order=3)]
        public genericRailML.TElementWithReference OperationalUndertaking { get; set; }
        
        [XmlElementAttribute("concessionaire", Order=4)]
        public genericRailML.TElementWithReference Concessionaire { get; set; }
        
        [XmlElementAttribute("contractor", Order=5)]
        public genericRailML.TElementWithReference Contractor { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<System.Xml.Linq.XElement> _any;
        
        [XmlAnyElementAttribute(Order=6)]
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
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EOrganizationalUnitBinding" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EOrganizationalUnitBinding" /> class.</para>
        /// </summary>
        public EOrganizationalUnitBinding()
        {
            this._any = new Collection<System.Xml.Linq.XElement>();
        }
    }
}
