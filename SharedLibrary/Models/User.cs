using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class User
    {
        [Key]
        [DisplayName("User Id")]
        public int Id { get; set; }

        [Required]
        [DisplayName("User FirstName")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in length.")]
        [Column(TypeName = "nvarchar(50)")]
        public string FirstName { get; set; }

        [DisplayName("User LastName")]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in length.")]
        public string LastName { get; set; }

        [DisplayName("User PhoneNumber")]
        [Column(TypeName = "varchar(15)")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in length.")]
        public string PhoneNumber { get; set; }

        [DisplayName("User Email")]
        [Column(TypeName = "varchar(50)")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Must be between {1} and {2} character in length.")]
        public string Email { get; set; }

        [DisplayName("User Password")]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Must be atleast {2} character in length.")]
        public string Password { get; set; }

        [DisplayName("User Business")]
        [Column(TypeName = "varchar(160)")]
        [StringLength(160, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in length.")]
        public string Business { get; set; }

        [DisplayName("User Private")]
        [Column(TypeName = "nvarchar(50)")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Must be between {1} and {2} character in length.")]
        public string Private { get; set; }
    }
}
