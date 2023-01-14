using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PetShop.Model.Models
{
    public class Adopter
    {
        [Key]
        public int AdopterID { get; set; }
        [StringLength(50), Required] //kitap adının girilmesi zorunlu olsun diye required dedik ve uzunluğu 50 olsun dedik.
        public string AdopterName { get; set; }
        public int AdopterAge { get; set; }
        [StringLength(50),Required]
        public string AdopterAdress { get; set; }
        [StringLength(11), Required]
        public string AdopterPhone { get; set; }
        //bir sahibin birden fazla hayvanı olabilir.
        public virtual List<Animal> Animal { get; set; } = new List<Animal>();
        //Bir hizmetin birden fazla sahibi olabilir.
        [ForeignKey("Service")]
        public int ServiceID { get; set; }
        public virtual Service Service { get; set; } //yazarlar tablosu ile bağlamak için virtual kullanıyoruz.Sanal bir bağlantı olarak kullanıcağımız için eğer gerçek bir bağlantı olsaydı ovveride yapmalıydık.

    }
}
