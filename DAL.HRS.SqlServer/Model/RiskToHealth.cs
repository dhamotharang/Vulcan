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
    
    public partial class RiskToHealth
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RiskToHealth()
        {
            this.RiskToHealthHealthRisks_CoshhRiskAssessmentRiskAssessments = new HashSet<RiskToHealthHealthRisks_CoshhRiskAssessmentRiskAssessments>();
        }
    
        public int OID { get; set; }
        public Nullable<int> Risk { get; set; }
        public string Comment { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual RiskToHealthType RiskToHealthType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiskToHealthHealthRisks_CoshhRiskAssessmentRiskAssessments> RiskToHealthHealthRisks_CoshhRiskAssessmentRiskAssessments { get; set; }
    }
}