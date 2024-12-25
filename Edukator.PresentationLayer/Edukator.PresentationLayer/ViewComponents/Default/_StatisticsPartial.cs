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
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.categoryCount = context.Categories.Count();
            ViewBag.courseCount = context.Courses.Count();
            ViewBag.personalCount = 685;
            var values = _statisticService.TGetList();
            return View(values);
        }
    }
}
