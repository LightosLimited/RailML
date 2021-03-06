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
    [SerializableAttribute()]
    [XmlTypeAttribute("eStatistic", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    internal partial class EStatistic : genericRailML.TStatistic
    {
        
        [XmlElementAttribute("mean", Order=0)]
        public genericRailML.TStatisticTimes Mean { get; set; }
        
        [XmlElementAttribute("median", Order=1)]
        public genericRailML.TStatisticTimes Median { get; set; }
        
        [XmlElementAttribute("standardDeviation", Order=2)]
        public genericRailML.TStandardDeviationTimes StandardDeviation { get; set; }
        
        [XmlIgnoreAttribute()]
        private Collection<genericRailML.TStatisticAnalyses> _statisticAnalyses;
        
        [XmlElementAttribute("statisticAnalyses", Order=3)]
        public Collection<genericRailML.TStatisticAnalyses> StatisticAnalyses
        {
            get
            {
                return this._statisticAnalyses;
            }
            private set
            {
                this._statisticAnalyses = value;
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Ruft einen Wert ab, der angibt, ob die StatisticAnalyses-Collection leer ist.</para>
        /// <para xml:lang="en">Gets a value indicating whether the StatisticAnalyses collection is empty.</para>
        /// </summary>
        [XmlIgnoreAttribute()]
        [NotMappedAttribute()]
        public bool StatisticAnalysesSpecified
        {
            get
            {
                return (this.StatisticAnalyses.Count != 0);
            }
        }
        
        /// <summary>
        /// <para xml:lang="de">Initialisiert eine neue Instanz der <see cref="EStatistic" /> Klasse.</para>
        /// <para xml:lang="en">Initializes a new instance of the <see cref="EStatistic" /> class.</para>
        /// </summary>
        public EStatistic()
        {
            this._statisticAnalyses = new Collection<genericRailML.TStatisticAnalyses>();
        }
    }
}
