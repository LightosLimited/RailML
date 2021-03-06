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
    [System.Xml.Serialization.XmlTypeAttribute("tController", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class TController : genericRailML.TElementWithIDAndName, IAController
    {
        
        /// <summary>
        /// <para>Container to define disabled/enabled controllers</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("states", Order=0)]
        public TStates States { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TElementRefInGroup> _ocpRef;
        
        /// <summary>
        /// <para>reference from a controller to an OCP</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ocpRef", Order=1)]
        public System.Collections.ObjectModel.Collection<genericRailML.TElementRefInGroup> OcpRef
        {
            get
            {
                return this._ocpRef;
            }
            private set
            {
                this._ocpRef = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OcpRef-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OcpRef collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool OcpRefSpecified
        {
            get
            {
                return (this.OcpRef.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TController" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TController" /> class.</para>
        /// </summary>
        public TController()
        {
            this._ocpRef = new System.Collections.ObjectModel.Collection<genericRailML.TElementRefInGroup>();
        }
        
        /// <summary>
        /// <para>reference to parent controller</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("parentControllerRef")]
        public string ParentControllerRef { get; set; }
        
        /// <summary>
        /// <para>(product) name of the controller</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("model")]
        public string Model { get; set; }
        
        /// <summary>
        /// <para>type of controller regarding its complexity and responsibility</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("type")]
        public string Type { get; set; }
        
        /// <summary>
        /// <para>technology that the controller is based on</para>
        /// </summary>
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.Xml.Serialization.XmlAttributeAttribute("technologyType")]
        public TControllerTechnologyType TechnologyTypeValue { get; set; }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TechnologyType-Eigenschaft spezifiziert ist, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value indicating whether the TechnologyType property is specified.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public bool TechnologyTypeValueSpecified { get; set; }
        
        /// <summary>
        /// <para>technology that the controller is based on</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public System.Nullable<TControllerTechnologyType> TechnologyType
        {
            get
            {
                if (this.TechnologyTypeValueSpecified)
                {
                    return this.TechnologyTypeValue;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.TechnologyTypeValue = value.GetValueOrDefault();
                this.TechnologyTypeValueSpecified = value.HasValue;
            }
        }
        
        /// <summary>
        /// <para>controller software version</para>
        /// </summary>
        [System.Xml.Serialization.XmlAttributeAttribute("swVersion")]
        public string SwVersion { get; set; }
    }
}
