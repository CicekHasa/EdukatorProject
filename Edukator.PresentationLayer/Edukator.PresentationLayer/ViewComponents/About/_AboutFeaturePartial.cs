using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutFeaturePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
