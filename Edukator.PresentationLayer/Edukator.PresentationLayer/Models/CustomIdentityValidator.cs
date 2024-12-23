using Microsoft.AspNetCore.Identity;

namespace Edukator.PresentationLayer.Models
{
    public class CustomIdentityValidator:IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",//Method adı gelen hata kodudur.
                Description = "Parola çok kısa, lütfen 6 karakter bir veri girişi yapın."//O hata kodunda özel olarak gelmesini istediğim mesaj
            };
        }

        public override IdentityError PasswordRequiresLower()
        {
            return new IdentityError()
            {
                Code= "PasswordRequiresLower",
                Description="En az 1 adet küçük harf içermelidir."
            };
        }

        public override IdentityError PasswordRequiresUpper()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresUpper",
                Description="Parola en az 1 adet büyük harf içermelidir."
            };
        }

        public override IdentityError PasswordRequiresNonAlphanumeric()
        {
            return new IdentityError()
            {
                Code = "PasswordRequiresNonAlphanumeric",
                Description = "Parola da en az bir alfasayısal olmayan karakter bulunmalıdır."
            };
        }
    }
}
