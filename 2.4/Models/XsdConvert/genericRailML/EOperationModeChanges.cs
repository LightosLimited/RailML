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
    [System.Xml.Serialization.XmlTypeAttribute("eOperationModeChanges", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EOperationModeChanges
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.KeyAttribute()]
        public long Id { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TOperationModeChange> _operationModeChange;
        
        [System.Xml.Serialization.XmlElementAttribute("operationModeChange", Order=0)]
        public System.Collections.ObjectModel.Collection<genericRailML.TOperationModeChange> OperationModeChange
        {
            get
            {
                return this._operationModeChange;
            }
            private set
            {
                this._operationModeChange = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die OperationModeChange-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the OperationModeChange collection is empty.</para>
        /// </summary>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
        public bool OperationModeChangeSpecified
        {
            get
            {
                return (this.OperationModeChange.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EOperationModeChanges" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EOperationModeChanges" /> class.</para>
        /// </summary>
        public EOperationModeChanges()
        {
            this._operationModeChange = new System.Collections.ObjectModel.Collection<genericRailML.TOperationModeChange>();
        }
    }
}
