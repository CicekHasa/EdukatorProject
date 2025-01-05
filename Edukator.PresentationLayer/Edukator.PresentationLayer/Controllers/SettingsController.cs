using Edukator.EntityLayer.Concrete;
using Edukator.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Edukator.PresentationLayer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            //Name'e göre listeleme sebebimiz username ile giriş yapıldığı için! Login sayfasında yaptığımız giriş
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.ImageUrl = values.ImageUrl;
            userEditViewModel.Email = values.Email;
            userEditViewModel.UserName = values.UserName;
            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);//Login olan isme göre kullanıcıyı bul!
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();//şu anki projenin çalıştığı kaynağı verir.
                var extension = Path.GetExtension(p.Image.FileName);//dosya uzantısını döner.
                var imageName = Guid.NewGuid() + extension;//benzersiz bir isim oluşturması için kullanılır.
                var saveLocation = resource + "/wwwroot/userimages/" + imageName;//dosyayı kayıt edeceğim yolu atarız.
                var stream = new FileStream(saveLocation, FileMode.Create);//belirttiğim yola yeni bir dosya oluşturmak için.
                await p.Image.CopyToAsync(stream);//Belirttiğim path'e resmi kopyalamak için kullanılır.
                user.ImageUrl = "/userimages/" + imageName;
            }
            user.Name = p.Name;
            user.Surname = p.Surname;
            user.Email = p.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);//Belirttiğim kullanıcının yazdığı şifre hashlenip sonra PasswordHash'e atanır.
            var result = await _userManager.UpdateAsync(user);//Verileri Günceller.
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }
    }
}
