using Edukator.BusinessLayer.Abstract;
using Edukator.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _StatisticsPartial : ViewComponent
    {
        private readonly IStatisticService _statisticService;

        public _StatisticsPartial(IStatisticService statisticService)
        {
            _statisticService = statisticService;
        }
        
        public IViewComponentResult Invoke()
        {
            using var context = new Context();
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.courseCount = context.Courses.Count();
            ViewBag.personalCount = 685;
            var values = _statisticService.TGetList();
            return View(values);
        }
    }
}
