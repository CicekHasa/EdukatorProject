using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        //Interface'i kalıtım olarak kullandığında interface içindeki methodlar kullanıldığı
        //class'a implemente edilmeli!

        //Her methoddaki işlemi Context sınıfı içindeki methodlardan ulaşacağız.
        public void Delete(T t)
        {
            var context = new Context();
            context.Remove(t);
            context.SaveChanges();//Db ye kayıt eder.
        }

        public T GetByID(int id)
        {
            var context = new Context();
            return context.Set<T>().Find(id);
            //Set yazmamızın  sebebi hangi entity classının içindeki veriyi id ye göre bulacağını belirtmek için!
        }

        public List<T> GetList()
        {
            var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            var context = new Context();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            var context = new Context();
            context.Update(t);
        }
    }
}
