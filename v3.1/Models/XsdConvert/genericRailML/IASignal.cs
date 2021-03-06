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
    internal partial interface IASignal
    {
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> Sight
        {
            get;
            set;
        }
        
        string Type
        {
            get;
            set;
        }
        
        string Function
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED since it is not needed and not used.</para>
        /// </summary>
        string SigSystem
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED: use attribute 'switchable' in sub-elements instead</para>
        /// </summary>
        System.Nullable<bool> Switchable
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// </summary>
        System.Nullable<bool> MaskableRoute
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// </summary>
        System.Nullable<bool> MaskableATC
        {
            get;
            set;
        }
        
        [System.ComponentModel.DefaultValueAttribute(false)]
        bool Virtual
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED: use attribute 'controllerRef' instead</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string SignalBoxOcpRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED: use attribute 'ocpStationRef' instead</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string StationOcpRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>DEPRECATED with railML 2.4 since it is not being used; refers to interlocking content</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> DistNearestDangerPoint
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> TrackDist
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> Height
        {
            get;
            set;
        }
    }
}
