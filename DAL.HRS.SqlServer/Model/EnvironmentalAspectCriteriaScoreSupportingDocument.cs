//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.HRS.SqlServer.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class EnvironmentalAspectCriteriaScoreSupportingDocument
    {
        public System.Guid Oid { get; set; }
        public Nullable<System.Guid> File { get; set; }
        public Nullable<int> EnvironmentalAspectCriteriaScore { get; set; }
        public Nullable<int> EnvironmentalAspectCriteriaType { get; set; }
        public string Comments { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual EnvironmentalAspectCriteriaScore EnvironmentalAspectCriteriaScore1 { get; set; }
        public virtual EnvironmentalAspectCriteriaType EnvironmentalAspectCriteriaType1 { get; set; }
        public virtual MyFileData MyFileData { get; set; }
    }
}
