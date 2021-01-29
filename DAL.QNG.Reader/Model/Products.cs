//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.QNG.Reader.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Products
    {
        public string COID { get; set; }
        public int id { get; set; }
        public Nullable<int> version { get; set; }
        public Nullable<System.DateTime> cdate { get; set; }
        public Nullable<System.DateTime> mdate { get; set; }
        public Nullable<int> cuser_id { get; set; }
        public Nullable<int> muser_id { get; set; }
        public string status { get; set; }
        public Nullable<int> buyer_id { get; set; }
        public Nullable<int> category_id { get; set; }
        public string code { get; set; }
        public string other_code { get; set; }
        public string size { get; set; }
        public Nullable<int> grade_id { get; set; }
        public string sequence { get; set; }
        public string description { get; set; }
        public string size_description { get; set; }
        public Nullable<bool> size_in_description { get; set; }
        public Nullable<decimal> density { get; set; }
        public Nullable<int> identifying_mark_id { get; set; }
        public Nullable<int> analysis1_id { get; set; }
        public Nullable<int> analysis2_id { get; set; }
        public Nullable<int> analysis3_id { get; set; }
        public Nullable<int> analysis4_id { get; set; }
        public Nullable<int> vat_type1_id { get; set; }
        public Nullable<int> vat_type2_id { get; set; }
        public Nullable<int> vat_type3_id { get; set; }
        public Nullable<int> vat_type4_id { get; set; }
        public Nullable<int> commodity_id { get; set; }
        public Nullable<decimal> dim1_static_dimension { get; set; }
        public Nullable<decimal> dim1_minimum_offcut { get; set; }
        public Nullable<decimal> dim2_static_dimension { get; set; }
        public Nullable<decimal> dim2_minimum_offcut { get; set; }
        public Nullable<decimal> dim3_static_dimension { get; set; }
        public Nullable<decimal> dim3_minimum_offcut { get; set; }
        public Nullable<decimal> dim4_static_dimension { get; set; }
        public Nullable<decimal> dim4_minimum_offcut { get; set; }
        public Nullable<decimal> dim5_static_dimension { get; set; }
        public Nullable<decimal> dim5_minimum_offcut { get; set; }
        public string notes { get; set; }
        public string specification_value1 { get; set; }
        public string specification_value2 { get; set; }
        public string specification_value3 { get; set; }
        public string specification_value4 { get; set; }
        public string specification_value5 { get; set; }
        public Nullable<int> sales_costing_type_id { get; set; }
        public Nullable<int> enquiry_cost_shown_id { get; set; }
        public Nullable<int> source_product_id { get; set; }
        public Nullable<decimal> standard_cost { get; set; }
        public Nullable<int> sales_group_id { get; set; }
        public Nullable<int> minimum_grade_id { get; set; }
        public string description_formula { get; set; }
        public Nullable<decimal> minimum_margin { get; set; }
        public string sales_notes { get; set; }
        public string purchase_notes { get; set; }
        public string specification_value6 { get; set; }
        public string specification_value7 { get; set; }
        public string specification_value8 { get; set; }
        public string specification_value9 { get; set; }
        public string specification_value10 { get; set; }
        public Nullable<int> purchase_group_id { get; set; }
        public Nullable<bool> dim1_production_override { get; set; }
        public Nullable<bool> dim2_production_override { get; set; }
        public Nullable<bool> dim3_production_override { get; set; }
        public Nullable<bool> dim4_production_override { get; set; }
        public Nullable<bool> dim5_production_override { get; set; }
        public Nullable<bool> require_certification { get; set; }
        public Nullable<int> alternate_product_id { get; set; }
        public Nullable<int> specification1_id { get; set; }
        public Nullable<int> specification2_id { get; set; }
        public Nullable<int> specification3_id { get; set; }
        public Nullable<int> specification4_id { get; set; }
        public Nullable<int> specification5_id { get; set; }
        public Nullable<int> specification6_id { get; set; }
        public Nullable<int> specification7_id { get; set; }
        public Nullable<int> specification8_id { get; set; }
        public Nullable<int> specification9_id { get; set; }
        public Nullable<int> specification10_id { get; set; }
        public Nullable<int> dim1_type_id { get; set; }
        public Nullable<int> dim2_type_id { get; set; }
        public Nullable<int> dim3_type_id { get; set; }
        public Nullable<int> dim4_type_id { get; set; }
        public Nullable<int> dim5_type_id { get; set; }
        public string ledger_segment_code { get; set; }
        public Nullable<int> default_stock_status_id { get; set; }
        public string testing_notes { get; set; }
        public Nullable<int> cutting_group_cost_id { get; set; }
        public Nullable<decimal> guide_cost { get; set; }
        public Nullable<decimal> guide_price { get; set; }
        public Nullable<decimal> fabrication_price { get; set; }
        public Nullable<int> scrap_product_id { get; set; }
        public Nullable<decimal> dim1_negative_tolerance { get; set; }
        public Nullable<decimal> dim1_positive_tolerance { get; set; }
        public Nullable<decimal> dim2_negative_tolerance { get; set; }
        public Nullable<decimal> dim2_positive_tolerance { get; set; }
        public Nullable<decimal> dim3_negative_tolerance { get; set; }
        public Nullable<decimal> dim3_positive_tolerance { get; set; }
        public Nullable<decimal> dim4_negative_tolerance { get; set; }
        public Nullable<decimal> dim4_positive_tolerance { get; set; }
        public Nullable<decimal> dim5_negative_tolerance { get; set; }
        public Nullable<decimal> dim5_positive_tolerance { get; set; }
        public Nullable<bool> non_traceable_uses_location { get; set; }
        public Nullable<decimal> dim1_kerf { get; set; }
        public Nullable<decimal> dim2_kerf { get; set; }
        public Nullable<decimal> dim3_kerf { get; set; }
        public Nullable<decimal> dim4_kerf { get; set; }
        public Nullable<decimal> dim5_kerf { get; set; }
        public Nullable<System.DateTime> ETLCreateDate { get; set; }
        public Nullable<System.DateTime> ETLUpdateDate { get; set; }
        public Nullable<bool> default_consumed_dim_in_production1 { get; set; }
        public Nullable<bool> default_consumed_dim_in_production2 { get; set; }
        public Nullable<bool> default_consumed_dim_in_production3 { get; set; }
        public Nullable<bool> default_consumed_dim_in_production4 { get; set; }
        public Nullable<bool> default_consumed_dim_in_production5 { get; set; }
    }
}