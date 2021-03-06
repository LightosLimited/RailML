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
    [XmlTypeAttribute("eLine", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class ELine : genericRailML.TLine
    {
        
        [XmlIgnoreAttribute()]
        private Collection<string> _lineDescr;
        
        /// <summary>
        /// <para>DEPRECATED with railML version 2.4</para>
        /// </summary>
        [XmlElementAttribute("lineDescr", Order=0)]
        public Collection<string> LineDescr
        {
            get
            {
                return this._lineDescr;
            }
            private set
            {
                this._lineDescr = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die LineDescr-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the LineDescr collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool LineDescrSpecified
        {
            get
            {
                return (this.LineDescr.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="ELine" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="ELine" /> class.</para>
        /// </summary>
        public ELine()
        {
            this._lineDescr = new Collection<string>();
            this._trackRef = new Collection<genericRailML.TTrackRefInGroup>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TTrackRefInGroup> _trackRef;
        
        [XmlElementAttribute("trackRef", Order=1)]
        public Collection<genericRailML.TTrackRefInGroup> TrackRef
        {
            get
            {
                return this._trackRef;
            }
            private set
            {
                this._trackRef = value;
            }
        }
    }
}
