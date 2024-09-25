using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        //Bağlantı adresi buradan alınacak!
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-LBN42TA\\SQLEXPRESS01; initial Catalog=DbEdukator; integrated security= true");
        }

        //Dbset de verilen değişken adı Tablonun adı olur. Daha çok class'ın çoğul adı olarak konulması tercih edilir.
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<CustomerFeedback> CustomerFeedbacks { get; set; }
        public DbSet<Mail> Mail { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
