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
    internal partial interface IAOperator
    {
        
        /// <summary>
        /// <para>DEPRECATED: name of vehicle operator, use reference to operator list instead</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        string OperatorName
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>reference to the vehicle operator entry</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string VehicleOperatorRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>vehicle class description of operator or complete identifier number in case of particular vehicle</para>
        /// </summary>
        string OperatorClass
        {
            get;
            set;
        }
    }
}
