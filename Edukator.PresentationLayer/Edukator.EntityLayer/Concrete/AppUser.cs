using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>//Bu sınıfın içinde AspNetUser tablosundaki alanlar var! AspNetUSer tablosundaki id alanı default string geliyor oraya int yapmak için bu şekilde parametre de primary key alanının değişken tipini belirleyebiliyoruz.
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }
        [StringLength(100)]//100 karakterlik sınır olsun alttaki prop için!
        public string ImageUrl { get; set; }
    }
}
