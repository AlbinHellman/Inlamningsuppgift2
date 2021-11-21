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
    public class Product
    {

        [Key]
        [DisplayName("product Id")]
        public int Id { get; set; }

        [Required]
        [DisplayName("product Name")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "* Part numbers must be between {1} and {2} character in length.")]
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; }



        [DisplayName("product Description")]
        [Column(TypeName = "nvarchar(max)")]
        [StringLength(8129, MinimumLength = 5, ErrorMessage = "Must be at least {2} character in length.")]
        public string Description { get; set; }



        [DisplayName("product Size")]
        [Column(TypeName = "varchar(15)")]
        public string Size { get; set; }


        [DisplayName("product ListPrice (SEK)")]
        [Column(TypeName = "money")]
        public decimal ListPrice { get; set; }


        [DisplayName("product InStock")]
        [Column(TypeName = "bit")]
        public bool InStock { get; set; }
    }
}
