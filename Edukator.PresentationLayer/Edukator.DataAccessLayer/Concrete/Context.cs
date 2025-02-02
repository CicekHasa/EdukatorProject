using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Concrete
{
    //AppUser entitysini ekleme sebebim AspNetUser tablosuna AppUser entity'si içindeki alanları eklemesi için!
    //AppRole ve int parametrelerini de ekleme sebebim, AspNetUser iel AspNetRole tablolarındaki id alanlarının string yerine int gelmesi için!
    public class Context : IdentityDbContext<AppUser, AppRole, int>//(IdentityDbContext de DbContext sınıfından miras alıyor.)
    {
        //Bağlantı adresi buradan alınacak!
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=HASANCICEKK\\MSSQLSERVER01; initial Catalog=DbEdukator; integrated security= true");
        }

        //Dbset de verilen değişken adı Tablonun adı olur. Daha çok class'ın çoğul adı olarak konulması tercih edilir.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<AboutGrid> AboutGrids { get; set; }
        public DbSet<CustomerFeedback> CustomerFeedbacks { get; set; }
        public DbSet<MailSubscribe> MailSubscribes { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Statistic> Statistics { get; set; }
        public DbSet<CourseRegister> CourseRegisters { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SiteFeature> SiteFeatures { get; set; }
        public DbSet<Teammate> Teammates { get; set; }
    }
}
