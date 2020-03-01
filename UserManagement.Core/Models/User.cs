// -----------------------------------------------------
//     Class name
//     Author: Alberto José Pedrera Ros
//------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;

namespace UserManagement.Core.Models
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [StringLength(100)]
        public string Country { get; set; }

        [StringLength(12)]
        public int PhoneNumber { get; set; }

        [StringLength(20)]
        public int PostalCode { get; set; }
    }
}