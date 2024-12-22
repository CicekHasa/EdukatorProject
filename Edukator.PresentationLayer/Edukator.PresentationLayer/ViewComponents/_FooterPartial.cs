using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents
{
    public class _FooterPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
