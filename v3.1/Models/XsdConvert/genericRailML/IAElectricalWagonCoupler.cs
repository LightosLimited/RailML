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
    internal partial interface IAElectricalWagonCoupler
    {
        
        /// <summary>
        /// <para>basic position of the electrical wagon coupler (front/rear/both)</para>
        /// </summary>
        TEndPositionType PositionOnCarEnd
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>description of the design type of the electrical coupler (mainly control lines)</para>
        /// </summary>
        string DesignType
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>the position of electrical coupling in relation to mechanical coupling if integrated</para>
        /// </summary>
        System.Nullable<TRelatedPositionType> PositionOnMechanicalCoupler
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>number of contacts included in the coupler (similar to number of lines)</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string NumberContacts
        {
            get;
            set;
        }
    }
}
