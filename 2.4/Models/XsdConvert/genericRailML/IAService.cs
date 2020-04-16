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
    internal partial interface IAService : genericRailML.IAnyAttribute
    {
        
        /// <summary>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        string Name
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>Code list for the special services based on the directory of passenger code lists for the ERA technical documents used in TAP TSI (B.4.7161)</para>
        /// <para>Values are outlined in the type7161CodeList (http://www.era.europa.eu/Document-Register/Documents/ERA_TAP_Passenger_Code_List_1.3.1.xsd)</para>
        /// <para xml:lang="en">Maximum length: 3.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.MaxLengthAttribute(3)]
        string TapTsiType7161Code
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>count="0" means: there is not such a service</para>
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
        
        /// <summary>
        /// <para>generic decimal value for additional information of the service, meaning should be clarified by its "description"</para>
        /// </summary>
        System.Nullable<decimal> Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>list of common service types</para>
        /// </summary>
        string Type
        {
            get;
            set;
        }
    }
}
