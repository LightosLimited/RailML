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
    internal partial interface IAServicePeriod : genericRailML.IATimePeriod
    {
        
        /// <summary>
        /// <para>a sequence of 1 and 0 for every day of the timetable period, indicating that the train runs or runs not on this specific date</para>
        /// <para xml:lang="en">Pattern: [0-1]*.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RegularExpressionAttribute("[0-1]*")]
        string BitMask
        {
            get;
            set;
        }
    }
}
