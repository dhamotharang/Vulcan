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
    
    public partial class Discipline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Discipline()
        {
            this.DisciplineHistory = new HashSet<DisciplineHistory>();
            this.DisciplineSupportingDocument = new HashSet<DisciplineSupportingDocument>();
        }
    
        public int OID { get; set; }
        public Nullable<int> Employee { get; set; }
        public Nullable<System.DateTime> DateOfAction { get; set; }
        public Nullable<System.DateTime> DateOfActionAppeals { get; set; }
        public Nullable<int> DisciplinaryActionType { get; set; }
        public Nullable<int> Manager { get; set; }
        public Nullable<System.DateTime> DateOfViolation { get; set; }
        public Nullable<int> NatureOfViolationType { get; set; }
        public Nullable<int> Location { get; set; }
        public Nullable<int> EmployeeInAgreement { get; set; }
        public Nullable<bool> RepresentativePresent { get; set; }
        public string RepresentativeName { get; set; }
        public string ManagerStatement { get; set; }
        public string EmployeeStatement { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual DisciplinaryActionType DisciplinaryActionType1 { get; set; }
        public virtual Employee Employee1 { get; set; }
        public virtual Location Location1 { get; set; }
        public virtual Employee Employee2 { get; set; }
        public virtual NatureOfViolationType NatureOfViolationType1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DisciplineHistory> DisciplineHistory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DisciplineSupportingDocument> DisciplineSupportingDocument { get; set; }
    }
}