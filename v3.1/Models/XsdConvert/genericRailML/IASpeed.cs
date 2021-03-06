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
    internal partial interface IASpeed
    {
        
        /// <summary>
        /// <para>DEPRECATED. Use the new attribute etcsTrainCategory instead.</para>
        /// <para>generic type for category names of trains; allowing digits, letters and white spaces; length not limited</para>
        /// </summary>
        string TrainCategory
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the international train category number as specified on page 38 in ERA_ERTMS_040001 "Assignment of values to ETCS variables" v1.9 from 10/07/12</para>
        /// <para>the international train category number as specified on page 38 in ERA_ERTMS_040001 "Assignment of values to ETCS variables" v1.9 from 10/07/12</para>
        /// <para xml:lang="en">Minimum inclusive value: 0.</para>
        /// <para xml:lang="en">Maximum inclusive value: 15.</para>
        /// </summary>
        [System.ComponentModel.DataAnnotations.RangeAttribute(typeof(decimal), "0", "15")]
        string EtcsTrainCategory
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>reference to a speedProfile</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string ProfileRef
        {
            get;
            set;
        }
        
        string Status
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>maximum allowed speed in km/h</para>
        /// </summary>
        string VMax
        {
            get;
            set;
        }
    }
}
