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
    
    public partial class XpoWorkflowDefinition
    {
        public System.Guid Oid { get; set; }
        public string Name { get; set; }
        public string Xaml { get; set; }
        public string TargetObjectType { get; set; }
        public string Criteria { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> AutoStartWhenObjectIsCreated { get; set; }
        public Nullable<bool> AutoStartWhenObjectFitsCriteria { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public Nullable<bool> AllowMultipleRuns { get; set; }
    }
}
