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
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute("eStatistic", Namespace="https://www.railml.org/schemas/2018")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    internal partial class EStatistic : genericRailML.TStatistic
    {
        
        [System.Xml.Serialization.XmlElementAttribute("mean", Order=0)]
        public genericRailML.TStatisticTimes Mean { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("median", Order=1)]
        public genericRailML.TStatisticTimes Median { get; set; }
        
        [System.Xml.Serialization.XmlElementAttribute("standardDeviation", Order=2)]
        public genericRailML.TStandardDeviationTimes StandardDeviation { get; set; }
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        private System.Collections.ObjectModel.Collection<genericRailML.TStatisticAnalyses> _statisticAnalyses;
        
        [System.Xml.Serialization.XmlElementAttribute("statisticAnalyses", Order=3)]
        public System.Collections.ObjectModel.Collection<genericRailML.TStatisticAnalyses> StatisticAnalyses
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        [System.ComponentModel.DataAnnotations.Schema.NotMappedAttribute()]
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
            this._statisticAnalyses = new System.Collections.ObjectModel.Collection<genericRailML.TStatisticAnalyses>();
        }
    }
}