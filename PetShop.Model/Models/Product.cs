using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [StringLength(50),Required]
        public string ProductName { get; set; }
        [Required]
        public string Category { get; set; }
        public int ProductStoke { get; set; }
        [Required]
        public int ProductPrice { get; set; }
        [StringLength(100)]
        public string ProductDescription { get; set; }

    }
}
