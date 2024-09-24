using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IGenericDal<Category>
    {
        //void Insert(Category category);
        //void Delete(Category category);
        //void Update(Category category);
        //List<Category> GetList();
        //Category GetByID(int id);

        //Yukarıda oluşturduklarımızı Generic interface de oluşturup oradan kalıtıyoruz.
    }
}
