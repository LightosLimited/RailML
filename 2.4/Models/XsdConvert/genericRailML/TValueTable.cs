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
    /// <summary>
    /// <para>table of values vs. arbitrary x-variable</para>
    /// </summary>
    [GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    [SerializableAttribute()]
    [XmlTypeAttribute("tValueTable", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlIncludeAttribute(typeof(genericRailML.EPulsePatternValueTable))]
    [XmlIncludeAttribute(typeof(TCurveValueTable))]
    internal partial class TValueTable
    {
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der diese Entität eindeutig identifiziert, oder legt diesen fest.</para>
        /// <para xml:lang="en">Gets or sets a value uniquely identifying this entity.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [KeyAttribute()]
        public long Id { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<TValueTableColumnHeader> _columnHeader;
        
        /// <summary>
        /// <para>List of Names to explain meaning of values</para>
        /// </summary>
        [XmlElementAttribute("columnHeader", Order=0)]
        public Collection<TValueTableColumnHeader> ColumnHeader
        {
            get
            {
                return this._columnHeader;
            }
            private set
            {
                this._columnHeader = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die ColumnHeader-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the ColumnHeader collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool ColumnHeaderSpecified
        {
            get
            {
                return (this.ColumnHeader.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="TValueTable" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="TValueTable" /> class.</para>
        /// </summary>
        public TValueTable()
        {
            this._columnHeader = new Collection<TValueTableColumnHeader>();
            this._valueLine = new Collection<TValueTableValueLine>();
        }
        
        [XmlIgnoreAttribute()]
        private Collection<TValueTableValueLine> _valueLine;
        
        /// <summary>
        /// <para>set of values related to an x-value (one table line)</para>
        /// </summary>
        [XmlElementAttribute("valueLine", Order=1)]
        public Collection<TValueTableValueLine> ValueLine
        {
            get
            {
                return this._valueLine;
            }
            private set
            {
                this._valueLine = value;
            }
        }
        
        /// <summary>
        /// <para>descriptive name for values of abscissa (x-axis)</para>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("xValueName")]
        public string XValueName { get; set; }
        
        /// <summary>
        /// <para>physical unit for values of abscissa (x-axis)</para>
        /// <para>enumeration of physical units</para>
        /// </summary>
        [XmlAttributeAttribute("xValueUnit")]
        public string XValueUnit { get; set; }
        
        /// <summary>
        /// <para>descriptive name of y-values in that column</para>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("yValueName")]
        public string YValueName { get; set; }
        
        /// <summary>
        /// <para>physical unit of the values in element "values"</para>
        /// <para>enumeration of physical units</para>
        /// </summary>
        [XmlAttributeAttribute("yValueUnit")]
        public string YValueUnit { get; set; }
        
        /// <summary>
        /// <para>descriptive name of z-value used as parameter in the value table</para>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        [XmlAttributeAttribute("zValueName")]
        public string ZValueName { get; set; }
        
        /// <summary>
        /// <para>physical unit for z-value used as parameter in the value table</para>
        /// <para>enumeration of physical units</para>
        /// </summary>
        [XmlAttributeAttribute("zValueUnit")]
        public string ZValueUnit { get; set; }
    }
}
