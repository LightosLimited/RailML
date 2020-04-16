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
    internal partial interface IAMonitoringSystem
    {
        
        /// <summary>
        /// <para>type of national system as enumeration</para>
        /// <para>use value from the separate code definition file 'TrainProtectionSystems.xml'/trainProtectionSystemsOnVehicle</para>
        /// </summary>
        string Type
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>type of transmission medium for the train protection system</para>
        /// </summary>
        genericRailML.TTrainProtectionMedium TrainProtectionMedium
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>way of information transmission between line-side and train-borne equipment</para>
        /// </summary>
        genericRailML.TTrainProtectionMonitoring TrainProtectionMonitoring
        {
            get;
            set;
        }
    }
}
