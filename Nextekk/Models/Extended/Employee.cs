using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Nextekk.Models
{
    public partial class Employee
    {
    }

    public class EmployeeMetadata
    {
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "First name required")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Last name required")]
        public string LastName { get; set; }

        [Display(Name = "Email ID")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email ID required")]
        [DataType(DataType.EmailAddress)]
        public string EmailID { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.DateTime)]   
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: MM//dd/yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Number of Children")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Number of Children required")]
        public int NumberOfChildren { get; set; }

        [Display(Name = "Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password required")]
        public string Password { get; set; }

        [Display(Name = "Confirm Password")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Confirm Password required")]
        public int Confirmpassword { get; set; }

    }

     
}