//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsuranceAppMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SignUp
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public Nullable<System.DateTime> Birthday { get; set; }
        public Nullable<int> CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string Dui { get; set; }
        public Nullable<int> Ticket { get; set; }
        public string Coverage { get; set; }
        public Nullable<decimal> EstimatedQuote { get; set; }
    }
}