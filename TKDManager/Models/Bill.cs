//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TKDManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public int BillID { get; set; }
        public int MemberID { get; set; }
        public double Amount { get; set; }
        public System.DateTime DueDate { get; set; }
        public System.DateTime PaidDate { get; set; }
    }
}
