using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.ViewComponents.Default
{
    public class _HeadPartial : ViewComponent /**Viewcomponent oluşturmak için 'ViewComponent' sınıfını miras alman gerek!*/
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
