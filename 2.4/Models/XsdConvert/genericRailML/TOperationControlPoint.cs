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
    [System.Xml.Serialization.XmlTypeAttribute("tOperationControlPoint", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(genericRailML.EOcp))]
    internal partial class TOperationControlPoint : TOcpWithIDAndName
    {
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TElementRefInGroup> _controllerRef;
        
        /// <summary>
        /// <para>reference from OCP to a Controller</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("controllerRef", Order=0)]
        public System.Collections.ObjectModel.Collection<genericRailML.TElementRefInGroup> ControllerRef
        {
            get
            {
                return this._controllerRef;
            }
            private set
            {
                this._controllerRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ControllerRef-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ControllerRef collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool ControllerRefSpecified
        {
            get
            {
                return (this.ControllerRef.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TOperationControlPoint" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TOperationControlPoint" /> class.</para>
        /// </summary>
        public TOperationControlPoint()
        {
            this._controllerRef = new System.Collections.ObjectModel.Collection<genericRailML.TElementRefInGroup>();
        }
        
        /// <summary>
        /// <para>DEPRECATED: use the 'designator' with its parameters 'register' and 'entry' instead</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("number")]
        public string Number { get; set; }
        
        /// <summary>
        /// <para>DEPRECATED: use the 'designator' with its parameters 'register' and 'entry' instead</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("abbrevation")]
        public string Abbrevation { get; set; }
        
        /// <summary>
        /// <para>timezone as defined in the tz database, e.g. "America/New_York"</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("timezone")]
        public string Timezone { get; set; }
        
        /// <summary>
        /// <para>references the one and only parent ocp of this ocp</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("parentOcpRef")]
        public string ParentOcpRef { get; set; }
    }
}
