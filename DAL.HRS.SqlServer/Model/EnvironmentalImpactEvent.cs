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
    
    public partial class EnvironmentalImpactEvent
    {
        public int OID { get; set; }
        public Nullable<int> EnvironmentalImpactIncident { get; set; }
        public Nullable<int> EnvironmentalImpactEventType { get; set; }
        public string Comment { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual EnvironmentalImpactEventType EnvironmentalImpactEventType1 { get; set; }
        public virtual EnvironmentalImpactIncident EnvironmentalImpactIncident1 { get; set; }
    }
}
