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
    internal partial interface IAPassenger
    {
        
        /// <summary>
        /// <para>number of decks per vehicle</para>
        /// </summary>
        System.Nullable<genericRailML.TVerbalCounter> Deck
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>flag, whether the vehicle comprises driving cab</para>
        /// </summary>
        System.Nullable<bool> DrivingCab
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>flag, whether the vehicle comprises tilting capabilities</para>
        /// </summary>
        System.Nullable<bool> Tilting
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>flag, whether the passenger compartment of the vehicle is air tight/pressure resistant</para>
        /// </summary>
        System.Nullable<bool> AirTightness
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>flag, whether the vehicle comprises a de-activation function of the emergency brake for long tunnels</para>
        /// </summary>
        System.Nullable<bool> EmergencyBrakeDeactivation
        {
            get;
            set;
        }
    }
}
