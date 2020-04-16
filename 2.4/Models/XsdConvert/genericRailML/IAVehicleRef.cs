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
    internal partial interface IAVehicleRef
    {
        
        /// <summary>
        /// <para>position of that vehicle (group) in the formation</para>
        /// <para>generic type for counters (e.g. order number of a vehicle in an formation), starting with '1'</para>
        /// </summary>
        string OrderNumber
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>vehicle type as reference</para>
        /// <para>an XML-side constrained reference to one xs:ID value, acts across an XML file including its outsourced components (xi:include mechanism)</para>
        /// </summary>
        string VehicleRef
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>number of consecutive vehicles of that type in the formation</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string VehicleCount
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>flag, whether there is a gangway at the front end of the vehicle usable</para>
        /// </summary>
        System.Nullable<bool> FrontGangway
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>flag, whether there is a gangway at the rear end of the vehicle usable</para>
        /// </summary>
        System.Nullable<bool> RearGangway
        {
            get;
            set;
        }
    }
}
