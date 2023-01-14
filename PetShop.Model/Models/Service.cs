using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Models
{
    public class Service
    {
        [Key]
        public int ServiceID { get; set; }
        [StringLength(50), Required] //kitap adının girilmesi zorunlu olsun diye required dedik ve uzunluğu 50 olsun dedik.
        public string ServiceName { get; set; }
        [Required]
        public int ServicePrice { get; set; }
        [Required]
        public string ServiceDescription { get; set; }
        //Bir hizmetin birden fazla sahibi olabilir
        public virtual List<Adopter> Adopter { get; set; } = new List<Adopter>();
        public virtual List<Volunteer> Volunteer { get; set; } = new List<Volunteer>();
    }
}
