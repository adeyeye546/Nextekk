//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nextekk.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailID { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public string Sex { get; set; }
        public int NumberOfChildren { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public bool IsEmailVierified { get; set; }
        public System.Guid AcivtivationCode { get; set; }
    }
}
