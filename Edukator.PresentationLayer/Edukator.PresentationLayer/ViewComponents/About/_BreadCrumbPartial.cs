using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _BreadCrumbPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
