using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.About
{
    public class _AboutJoinPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
