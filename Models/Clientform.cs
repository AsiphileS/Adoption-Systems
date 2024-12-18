//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Adoption_system.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Clientform
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string IdentityNumber { get; set; }
        [Required]
        public decimal AnnualSalary { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string EmploymentStatus { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        [Required]
        public string ChildName { get; set; }
        [Required]
        public string ReasonForAdoption { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }

      
    }
}
