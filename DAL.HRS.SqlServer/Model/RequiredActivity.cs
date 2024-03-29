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
    
    public partial class RequiredActivity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequiredActivity()
        {
            this.RequiredActivitySupportingDocument = new HashSet<RequiredActivitySupportingDocument>();
        }
    
        public int OID { get; set; }
        public Nullable<int> Employee { get; set; }
        public Nullable<int> ActivityType { get; set; }
        public Nullable<int> TrainingCourse { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CompletionDeadline { get; set; }
        public Nullable<System.DateTime> RevisedCompletionDeadline { get; set; }
        public Nullable<System.DateTime> DateCompleted { get; set; }
        public Nullable<int> CompletionStatus { get; set; }
        public string Comments { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual CompletionStatusType CompletionStatusType { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual RequiredActivityType RequiredActivityType { get; set; }
        public virtual TrainingCourse TrainingCourse1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredActivitySupportingDocument> RequiredActivitySupportingDocument { get; set; }
    }
}
