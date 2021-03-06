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
    internal partial interface IAMechanicalWagonCoupler
    {
        
        /// <summary>
        /// <para>design type of the mechanical wagon coupler</para>
        /// </summary>
        string DesignType
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>basic position of the mechanical wagon coupler (front/rear/both)</para>
        /// </summary>
        TEndPositionType PositionOnCarEnd
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>coupling level above top of rail in mm</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> CouplingHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>maximum force in Newton to be used for pulling vehicles with this type of coupling</para>
        /// <para>generic type for force values measured in newton</para>
        /// </summary>
        System.Nullable<decimal> PullingForce
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>maximum force in Newton to be used for pushing vehicles with this type of coupling</para>
        /// <para>generic type for force values measured in newton</para>
        /// </summary>
        System.Nullable<decimal> PushingForce
        {
            get;
            set;
        }
    }
}
