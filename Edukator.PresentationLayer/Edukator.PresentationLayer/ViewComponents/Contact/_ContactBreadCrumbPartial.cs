using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Contact
{
    public class _ContactBreadCrumbPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
