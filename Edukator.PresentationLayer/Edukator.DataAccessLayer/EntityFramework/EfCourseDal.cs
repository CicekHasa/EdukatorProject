using Edukator.DataAccessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Edukator.DataAccessLayer.Repositories;
using Edukator.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edukator.DataAccessLayer.EntityFramework
{
    public class EfCourseDal : GenericRepository<Course>, ICourseDal
    {
        public List<Course> GetCoursesWithCategories()
        {
            using var context = new Context();
            return context.Courses.Include(x=>x.Category).ToList();
        }

        public List<Course> GetCoursesWithCategory()
        {
            using var context = new Context();
            return context.Courses.Include(x => x.Category).ToList();//Kursları getirirken Category alanında Category tablosundaki id değerine karşılık gelen name'i getirmesini sağlar.
        }

        public List<Course> GetLast5Course()
        {
            using var context=new Context();
            return context.Courses.OrderByDescending(x => x.CourseID).Take(5).ToList();
        }
    }
}
