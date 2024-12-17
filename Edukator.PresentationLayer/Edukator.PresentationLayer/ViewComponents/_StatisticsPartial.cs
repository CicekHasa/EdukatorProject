using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents
{
    public class _StatisticsPartial:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.courseCount = context.Courses.Count();
            ViewBag.personalCount = 685;
            return View();
        }
    }
}
