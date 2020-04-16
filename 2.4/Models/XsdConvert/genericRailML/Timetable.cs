//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

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
    [XmlTypeAttribute("timetable", Namespace="https://www.railml.org/schemas/2018")]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlRootAttribute("timetable", Namespace="https://www.railml.org/schemas/2018")]
    internal partial class Timetable : genericRailML.TTimetable
    {
        
        [XmlElementAttribute("timetablePeriods", Order=0)]
        public ETimetablePeriods TimetablePeriods { get; set; }
        
        [XmlElementAttribute("operatingPeriods", Order=1)]
        public EOperatingPeriods OperatingPeriods { get; set; }
        
        [XmlElementAttribute("categories", Order=2)]
        public ECategories Categories { get; set; }
        
        [XmlElementAttribute("annotations", Order=3)]
        public EAnnotations Annotations { get; set; }
        
        [XmlElementAttribute("trainParts", Order=4)]
        public ETrainParts TrainParts { get; set; }
        
        [XmlElementAttribute("trains", Order=5)]
        public ETrains Trains { get; set; }
        
        [XmlElementAttribute("trainGroups", Order=6)]
        public ETrainGroups TrainGroups { get; set; }
        
        [XmlElementAttribute("rosterings", Order=7)]
        public ERosterings Rosterings { get; set; }
    }
}
