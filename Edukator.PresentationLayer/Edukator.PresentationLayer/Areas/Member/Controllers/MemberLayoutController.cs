using Microsoft.AspNetCore.Mvc;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult MemberSideBarPartial()//Adminlayout daki sidebar dan farklı bir tasarım yapılacağı için ayrı ekleniyor!
        {
            return PartialView();
        }
    }
}
