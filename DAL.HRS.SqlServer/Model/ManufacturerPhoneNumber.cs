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
    
    public partial class ManufacturerPhoneNumber
    {
        public int OID { get; set; }
        public Nullable<int> Manufacturer { get; set; }
        public string Number { get; set; }
        public Nullable<int> PhoneType { get; set; }
        public Nullable<int> OptimisticLockField { get; set; }
        public Nullable<int> GCRecord { get; set; }
    
        public virtual Manufacturer Manufacturer1 { get; set; }
        public virtual PhoneType PhoneType1 { get; set; }
    }
}
