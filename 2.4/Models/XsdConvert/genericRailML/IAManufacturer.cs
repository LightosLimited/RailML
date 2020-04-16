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
    internal partial interface IAManufacturer
    {
        
        /// <summary>
        /// <para>DEPRECATED: name of manufacturer, use reference to manufacturer list instead</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        string ManufacturerName
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>reference to the vehicle manufacturer entry</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string VehicleManufacturerRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>type description of manufacturer</para>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        string ManufacturerType
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>serial number from manufacturer for the particular vehicle</para>
        /// </summary>
        string SerialNumber
        {
            get;
            set;
        }
    }
}
