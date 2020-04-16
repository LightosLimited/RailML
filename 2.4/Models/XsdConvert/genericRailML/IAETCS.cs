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
    internal partial interface IAETCS
    {
        
        /// <summary>
        /// <para>Version of ETCS language (SRS edition) installed</para>
        /// <para>an arbitrary version number for any system; allowing digits, letters and white space</para>
        /// </summary>
        string SrsVersion
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>on-board unit supports level 0</para>
        /// </summary>
        System.Nullable<bool> Level_0
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>on-board unit supports level 1</para>
        /// </summary>
        System.Nullable<bool> Level_1
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>on-board unit supports level 2</para>
        /// </summary>
        System.Nullable<bool> Level_2
        {
            get;
            set;
        }
        
        /// <summary>
        /// <para>on-board unit supports level 3</para>
        /// </summary>
        System.Nullable<bool> Level_3
        {
            get;
            set;
        }
    }
}
