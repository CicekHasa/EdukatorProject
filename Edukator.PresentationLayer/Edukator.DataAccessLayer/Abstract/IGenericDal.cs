using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    //Burada Generic bir interface oluşturarak Tüm Abstract klasörü içindeki interfacelerdeki methodları burada oluşturup diğer interfacelerde bu generic interface'i kalıtacağız.
    public interface IGenericDal<T> where T : class
    {
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetByID(int id);
    }
}
