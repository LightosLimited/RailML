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
    internal partial interface IAPlaces
    {
        
        string Category
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>Code list for the facility type description based on the directory of passenger code lists for the ERA technical documents used in TAP TSI (B.4.9039)</para>
        /// <para>Values are outlined in the type9039CodeList (http://www.era.europa.eu/Document-Register/Documents/ERA_TAP_Passenger_Code_List_1.3.1.xsd)</para>
        /// <para xml:lang="en">Maximum length: 3.</para>
        /// </summary>
        [MaxLengthAttribute(3)]
        string TapTsiType9039Code
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>count="0" means: there is no place of this category</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string Count
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>an detailed description of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        string Description
        {
            get;
            set;
        }
    }
}
