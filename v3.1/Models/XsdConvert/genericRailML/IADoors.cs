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
    internal partial interface IADoors
    {
        
        /// <summary>
        /// <para>number of doors per vehicle at each side</para>
        /// <para>generic type for counters (e.g. number of equipment), allowing zero</para>
        /// </summary>
        string Number
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>height of entrance foot plate above rail top</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> EntranceHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>maximum distance between the doors of the vehicle</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> EntranceLength
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>total of all door width of the vehicle at one side</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> EntranceWidth
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>height of lowest foot step above rail top</para>
        /// <para>generic type for length values measured in meter</para>
        /// </summary>
        System.Nullable<decimal> FootStepHeight
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>speed limit for locking the doors during train ride</para>
        /// <para>generic type for speed/velocity values measured in kilometer per hour</para>
        /// </summary>
        System.Nullable<decimal> LockingSpeed
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>Time from stand-still of the vehicle to the flow of passengers can start through the doors. This is estimated to be at a door gap of 80cm.</para>
        /// </summary>
        string OpeningTime
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>Time after closing signal is given on the last door to the vehicles can be put in motion.</para>
        /// </summary>
        string ClosingTime
        {
            get;
            set;
        }
    }
}
