using System.ComponentModel.DataAnnotations;

namespace Randevu_Yonetim_Sistemi.Models
{
    public class LoginViewModel
    {

        [Required(ErrorMessage = "Lütfen Kullanıcı Adınızı Belirtiniz.")]
        [Display(Name = "Kullanıcı Adınız:")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen Şifrenizi Belirtiniz.")]
        [Display(Name = "Şifreniz:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Beni Hatırla")]
        public bool RememberMe { get; set; }



    }
}
