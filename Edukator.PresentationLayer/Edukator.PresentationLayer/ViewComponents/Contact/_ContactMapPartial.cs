using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Contact
{
    public class _ContactMapPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
