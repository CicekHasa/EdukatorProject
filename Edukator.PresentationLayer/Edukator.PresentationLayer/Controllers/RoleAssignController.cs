using Edukator.EntityLayer.Concrete;
using Edukator.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class RoleAssignController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _userManager;

        public RoleAssignController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _userManager.Users.ToList();
            return View(values);
        }

        [HttpGet]
        public async Task<IActionResult> UserRoleAssign(int id)
        {
            var user = _userManager.Users.FirstOrDefault(x => x.Id == id);//seçilen kişinin id sine göre kullanıcıyı getirir.
            TempData["userid"] = user.Id;
            var roles = _roleManager.Roles.ToList();//Tüm rolleri getirir.
            var userRoles = await _userManager.GetRolesAsync(user);//Seçilen kullanıcının hangi rolleri olduğunu getirir.
            List<RoleAssignViewModel> roleAssignViewModel = new List<RoleAssignViewModel>();

            foreach (var item in roles)
            {
                RoleAssignViewModel model = new RoleAssignViewModel();
                model.RoleID = item.Id;
                model.RoleName = item.Name;
                model.RoleExist = userRoles.Contains(item.Name);
                roleAssignViewModel.Add(model);
            }
            return View(roleAssignViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> UserRoleAssign(List<RoleAssignViewModel> model)
        {
            var userId = (int)TempData["userId"];
            var user=_userManager.Users.FirstOrDefault(x=>x.Id== userId);//id ye ait user'ı bulur.
            foreach (var item in model)
            {
                if (item.RoleExist)
                {
                    await _userManager.AddToRoleAsync(user, item.RoleName);//Yeni bir role ekler.
                }
                else
                {
                    await _userManager.RemoveFromRoleAsync(user, item.RoleName);//Var olan role alındıysa kullanıcıdan siler.
                }
            }
            return RedirectToAction("Index");
        }
    }
}
