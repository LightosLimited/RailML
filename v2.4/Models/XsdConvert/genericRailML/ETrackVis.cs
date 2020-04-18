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
    [XmlTypeAttribute("eTrackVis", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class ETrackVis : genericRailML.TElementWithReference
    {
        
        [XmlIgnoreAttribute()]
        private Collection<ETrackElementVis> _trackElementVis;
        
        /// <summary>
        /// <para>visualization of a railway track element</para>
        /// </summary>
        [XmlElementAttribute("trackElementVis", Order=0)]
        public Collection<ETrackElementVis> TrackElementVis
        {
            get
            {
                return this._trackElementVis;
            }
            private set
            {
                this._trackElementVis = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die TrackElementVis-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the TrackElementVis collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool TrackElementVisSpecified
        {
            get
            {
                return (this.TrackElementVis.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ETrackVis" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ETrackVis" /> class.</para>
        /// </summary>
        public ETrackVis()
        {
            this._trackElementVis = new Collection<ETrackElementVis>();
        }
    }
}