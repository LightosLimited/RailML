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
    internal partial interface IAAssemblyNameNumber
    {
        
        /// <summary>
        /// <para>number of assemblies per vehicle/unit</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string Count
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>type of assembly as descriptive name</para>
        /// <para>system-wide known name of an railway facility (e.g. station, timetable period or vehicle), allowing digits, letters and white space</para>
        /// </summary>
        string AssemblyName
        {
            get;
            set;
        }
    }
}
