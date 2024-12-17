using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents
{
    public class _NavbarPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
