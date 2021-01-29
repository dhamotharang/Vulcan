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
    
    public partial class RequiredActivityType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequiredActivityType()
        {
            this.PlannedActivity = new HashSet<PlannedActivity>();
            this.RequiredActivity = new HashSet<RequiredActivity>();
        }
    
        public int OID { get; set; }
        public string Name { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
        public Nullable<bool> IsUsedBySystem { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlannedActivity> PlannedActivity { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RequiredActivity> RequiredActivity { get; set; }
    }
}