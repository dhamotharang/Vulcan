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
    
    public partial class BBS_DepartmentSubCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BBS_DepartmentSubCategory()
        {
            this.BBS_Observation = new HashSet<BBS_Observation>();
        }
    
        public int OID { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentDepartment { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual BBS_Department BBS_Department { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BBS_Observation> BBS_Observation { get; set; }
    }
}