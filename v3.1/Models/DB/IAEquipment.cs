//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// This C# code was generated by XmlSchemaClassGenerator version 1.0.0.0.
namespace Models.DB
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Xml.Serialization;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("XmlSchemaClassGenerator", "1.0.0.0")]
    internal partial interface IAEquipment
    {
        
        /// <summary>
        /// <para>use value from the separate code definition file 'TrainProtectionSystems.xml'/trainProtectionSystemsOnVehicle</para>
        /// </summary>
        string Type
        {
            get;
            set;
        }
        
        System.Nullable<bool> Uses
        {
            get;
            set;
        }
        
        string Description
        {
            get;
            set;
        }
    }
}