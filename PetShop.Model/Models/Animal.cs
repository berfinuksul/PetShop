using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }
        [StringLength(50), Required] //kitap adının girilmesi zorunlu olsun diye required dedik ve uzunluğu 50 olsun dedik.
        public string AnimalType { get; set; }
        [Required]
        public string AnimalGender { get; set; }
        public int AnimalAge { get; set; }
        //Bir sahibin birden fazla hayvanı olabilir
        [ForeignKey("Adopter")]
        public int AdopterID { get; set; }
        public virtual Adopter Adopter { get; set; } //sahipler tablosu ile bağlamak için virtual kullanıyoruz.Sanal bir bağlantı olarak kullanıcağımız için eğer gerçek bir bağlantı olsaydı ovveride yapmalıydık.

    }
}
