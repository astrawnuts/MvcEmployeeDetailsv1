using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcEmployeeDetails.Models
{
    public class Employee
    {

        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Full Address")]
        public string FullAddress { get; set; }

        [Display(Name = "Use The Full Address As The Mailing Address?")]
        public bool MailingAddressSameAsFullAddress { get; set; }
        
        [Display(Name = "Mailing Address")]
        public string? MailingAddress { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Citizenship Status")]
        public string CitizenshipStatus { get; set; }
        [DataType(DataType.Date)]

        [Display(Name = "Employment Start Date")]
        public DateTime EmploymentStartDate { get; set; }

        [Display(Name = "Employment Type")]
        public string EmploymentType { get; set; }
        
        [Display(Name = "Position Title")]
        public string PositionTitle { get; set; }

        [Display(Name = "Name Of Emergency Contact")]
        public string EmergencyContactName { get; set; }

        [Display(Name = "Relationship To Emergency Contact")]
        public string EmergencyContactRelationship { get; set; }

        [Display(Name = "Phone Number Of Emergency Contact")]
        public string EmergencyContactPhoneNumber { get; set; }
        
        [Display(Name = "Employee Signature")]
        public string EmployeeSignature { get; set; }

    }
}
