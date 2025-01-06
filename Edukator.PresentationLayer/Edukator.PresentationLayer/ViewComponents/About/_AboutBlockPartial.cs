using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutBlockPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
