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
    
    public partial class EmergencyContacts
    {
        public int OID { get; set; }
        public Nullable<int> Employee { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string Relationship { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual Employee Employee1 { get; set; }
    }
}