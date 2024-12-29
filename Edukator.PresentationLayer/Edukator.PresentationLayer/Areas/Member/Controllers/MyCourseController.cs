using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[Controller]/[action]")]//Bu route eklenmeyince Login den buraya yönlendiremeyiz!
    public class MyCourseController : Controller
    {
        private readonly ICourseRegisterService _courseRegisterService;
        private readonly UserManager<AppUser> _userManager;

        public MyCourseController(ICourseRegisterService courseRegisterService, UserManager<AppUser> userManager)
        {
            _courseRegisterService = courseRegisterService;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);//Giriş yapan kişiye ait bilgileri getirir isme göre
            var value = _courseRegisterService.TCourseRegisterListWithCourseByUser(values.Id);
            return View(value);
        }
    }
}
