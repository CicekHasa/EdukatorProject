using Edukator.BusinessLayer.Abstract;
using Edukator.BusinessLayer.Concrete;
using Edukator.DataAccessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace Edukator.PresentationLayer.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private ICategoryService _categoryService;

        public CourseController(ICourseService courseService, ICategoryService categoryService)
        {
            _courseService = courseService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var values = _courseService.TGetCourseWithCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCourse()
        {
            //Kategori entitysindeki alanları combobox'a atamak için getiriyoruz!
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }
                                         ).ToList();
            ViewBag.category = values;
            return View();
        }
        public IActionResult DeleteCourse(int id)
        {
            var values=_courseService.TGetByID(id);
            _courseService.TDelete(values);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult AddCourse(Course course)
        {
            _courseService.TInsert(course);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCourse(int id)
        {
            //Kategori entitysindeki alanları combobox'a atamak için getiriyoruz!
            List<SelectListItem> values = (from x in _categoryService.TGetList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }
                                         ).ToList();
            ViewBag.category = values;

            var value=_courseService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateCourse(Course course)
        {
            _courseService.TUpdate(course);
            return RedirectToAction("Index");
        }
    }
}
