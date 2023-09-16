using System.ComponentModel.DataAnnotations;

namespace Randevu_Yonetim_Sistemi.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı Adınızı Belirtiniz.")]
        [Display(Name ="Kullanıcı Adınız:")]
        public string UserName {  get; set; }
        [Required(ErrorMessage = "Lütfen Adınızı Belirtiniz.")]
        [Display(Name = "Adınız:")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen Soyadınızı Belirtiniz.")]
        [Display(Name = "Soyadınız:")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Lütfen Şifrenizi Belirtiniz.")]
        [Display(Name = "Şifreniz:")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Lütfen Emailinizi Belirtiniz.")]
        [Display(Name = "Emailiniz:")]
        [EmailAddress(ErrorMessage ="Lütfen Email alanını kontrol ediniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Lütfen randevu rengini Belirtiniz.")]
        [Display(Name = "Randevu Rengi:")]
        public string Color { get; set; }
        
        [Display(Name = "Doktorum")]
        public bool IsDentist { get; set; }
    }
}
