using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Edukator.PresentationLayer.Controllers
{
    public class UsersController : Controller
    {
        //Burada AppUser Identity den gelen AspNetUser tablosunu özelleştirdiğim için kullanıyorum. Ancak Identity nin verdiği AspNetUser tablosunu özelleştirmeseydim UserManager içerisinde Identity nin verdiği 'IdentityUser' sınıfını eklemeliydim!
        private readonly UserManager<AppUser> _userManager;

        public UsersController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }
    }
}
