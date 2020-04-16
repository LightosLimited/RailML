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
    internal partial interface IABlockPart
    {
        
        System.Nullable<System.DateTime> Begin
        {
            get;
            set;
        }
        
        [System.ComponentModel.DefaultValueAttribute("0")]
        string BeginDay
        {
            get;
            set;
        }
        
        System.Nullable<System.DateTime> End
        {
            get;
            set;
        }
        
        [System.ComponentModel.DefaultValueAttribute("0")]
        string EndDay
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string StartOcpRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string EndOcpRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string TrainPartRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string OperatingPeriodRef
        {
            get;
            set;
        }
        
        string Mission
        {
            get;
            set;
        }
        
        System.Nullable<bool> Fixed
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>generic type for length values measured in kilometer</para>
        /// </summary>
        System.Nullable<decimal> RunLength
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string VehicleRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string FormationRef
        {
            get;
            set;
        }
    }
}
