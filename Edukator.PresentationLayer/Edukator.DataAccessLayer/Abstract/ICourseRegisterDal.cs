using Edukator.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.Abstract
{
    public interface ICourseRegisterDal:IGenericDal<CourseRegister>
    {
        //Bu entity'e özgü bir method
        List<CourseRegister> CourseRegisterListWithCourseAndUsers();
    }
}
