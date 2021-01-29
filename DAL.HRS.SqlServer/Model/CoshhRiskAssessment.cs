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
    
    public partial class CoshhRiskAssessment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CoshhRiskAssessment()
        {
            this.CoshhRiskAssessments_HealthSurveillanceTypes = new HashSet<CoshhRiskAssessments_HealthSurveillanceTypes>();
            this.CoshhRiskAssessments_PersonsAtRisk = new HashSet<CoshhRiskAssessments_PersonsAtRisk>();
            this.RiskControlAdditionalHazardControls_CoshhRiskAssessmentRiskAssessmentsWhereThisIsAdditionalHazardControl = new HashSet<RiskControlAdditionalHazardControls_CoshhRiskAssessmentRiskAssessmentsWhereThisIsAdditionalHazardControl>();
            this.RiskControlCurrentControls_CoshhRiskAssessmentRiskAssessmentsWhereThisIsCurrentControl = new HashSet<RiskControlCurrentControls_CoshhRiskAssessmentRiskAssessmentsWhereThisIsCurrentControl>();
            this.RiskToHealthHealthRisks_CoshhRiskAssessmentRiskAssessments = new HashSet<RiskToHealthHealthRisks_CoshhRiskAssessmentRiskAssessments>();
        }
    
        public int OID { get; set; }
        public Nullable<System.DateTime> AssessmentDate { get; set; }
        public Nullable<System.DateTime> NextReviewDate { get; set; }
        public Nullable<int> Location { get; set; }
        public Nullable<int> Department { get; set; }
        public Nullable<int> Product { get; set; }
        public string ProcessDescription { get; set; }
        public string WorkExposureLimits { get; set; }
        public Nullable<bool> IsExposureControlled { get; set; }
        public string IsExposureControlledComment { get; set; }
        public Nullable<int> RiskRatingWithControls { get; set; }
        public string RiskRatingComment { get; set; }
        public Nullable<bool> MatlStoredProperly { get; set; }
        public string MatlStoredProperlyComment { get; set; }
        public Nullable<bool> MatlDisposedProperly { get; set; }
        public string MatlDisposedProperlyComment { get; set; }
        public string PreparedBy { get; set; }
        public string ApprovedBy { get; set; }
        public Nullable<System.DateTime> ApprovedOn { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual CoshhProduct CoshhProduct { get; set; }
        public virtual Department Department1 { get; set; }
        public virtual Location Location1 { get; set; }
        public virtual RiskRating RiskRating { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoshhRiskAssessments_HealthSurveillanceTypes> CoshhRiskAssessments_HealthSurveillanceTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CoshhRiskAssessments_PersonsAtRisk> CoshhRiskAssessments_PersonsAtRisk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiskControlAdditionalHazardControls_CoshhRiskAssessmentRiskAssessmentsWhereThisIsAdditionalHazardControl> RiskControlAdditionalHazardControls_CoshhRiskAssessmentRiskAssessmentsWhereThisIsAdditionalHazardControl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiskControlCurrentControls_CoshhRiskAssessmentRiskAssessmentsWhereThisIsCurrentControl> RiskControlCurrentControls_CoshhRiskAssessmentRiskAssessmentsWhereThisIsCurrentControl { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RiskToHealthHealthRisks_CoshhRiskAssessmentRiskAssessments> RiskToHealthHealthRisks_CoshhRiskAssessmentRiskAssessments { get; set; }
    }
}