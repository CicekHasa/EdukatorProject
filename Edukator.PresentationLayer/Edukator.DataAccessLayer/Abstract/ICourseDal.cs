using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICourseDal:IGenericDal<Course>
    {
        //void Insert(Course course);
        //void Delete(Course course);
        //void Update(Course course);
        //List<Course> GetList();
        //Course GetByID(int id);



        //Yukarıda oluşturduklarımızı Generic interface de oluşturup oradan kalıtıyoruz.

        //Sadece bu entity'ye özel bir method! bu sebeple GenericRepo içinde yazmadık.
        List<Course> GetCoursesWithCategory();
    }
}
