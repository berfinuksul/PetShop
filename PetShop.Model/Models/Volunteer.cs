using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Models
{
    public class Volunteer
    {
        [Key]
        public int VolunteerID { get; set; }
        [StringLength(50), Required] //kitap adının girilmesi zorunlu olsun diye required dedik ve uzunluğu 50 olsun dedik.
        public string VolunteerName { get; set; }
        [Required]
        public int VolunteerAge { get; set; }
        [StringLength(11), Required]
        public string VolunteerPhone { get; set; }
        [StringLength(50)]
        public string VolunteerAdress { get; set; }
        //Bir hizmetin birden fazla gönüllüsü olabilir
        [ForeignKey("Service")]
        public int ServiceID { get; set; }
        public virtual Service Service { get; set; } //Hizmetler tablosu ile bağlamak için virtual kullanıyoruz.Sanal bir bağlantı olarak kullanıcağımız için eğer gerçek bir bağlantı olsaydı ovveride yapmalıydık.

    }
}
