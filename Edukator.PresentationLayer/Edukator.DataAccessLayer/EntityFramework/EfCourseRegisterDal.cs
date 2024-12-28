using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCourseRegisterDal : GenericRepository<CourseRegister>, ICourseRegisterDal
    {
        public List<CourseRegister> CourseRegisterListWithCourseAndUsers()
        {
            using var context = new Context();
            //CourseRegister'a AppUser ve Course'u dahile ettim.
            var values = context.CourseRegisters
    .Include(x => x.Course)
    .Include(y => y.AppUser)
    .OrderByDescending(c => c.CourseRegisterID) // Id'ye göre tersten sırala
    .Take(7) //  7 kaydı al
    .ToList();
            return values;
        }
    }
}
