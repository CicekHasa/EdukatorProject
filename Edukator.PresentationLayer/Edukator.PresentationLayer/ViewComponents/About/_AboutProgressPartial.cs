using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutProgressPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
