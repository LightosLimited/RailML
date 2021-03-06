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
    internal partial interface IARostering
    {
        
        /// <summary>
        /// <para>default vehicle, normally identical for all blockParts; can be superset by a certain blockPart</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string VehicleRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>default formation, normally identical for all blockParts; can be superset by a certain blockPart</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string FormationRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>depot or location this rostering belongs to</para>
        /// </summary>
        string Depot
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>default duration from the beginning of blocking of the resource until start of blockPart</para>
        /// </summary>
        string DefaultPreProcessingTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>default duration from the end of blockPart until the end of blocking of the resource</para>
        /// </summary>
        string DefaultPostProcessingTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>could be "conceptional" or "operational", or in case of timetable constraints for trainParts also "timetable"</para>
        /// </summary>
        string Scope
        {
            get;
            set;
        }
    }
}
