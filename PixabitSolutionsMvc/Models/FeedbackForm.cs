using System.ComponentModel.DataAnnotations;
using PixabitSolutionsMvc.Resources;


namespace PixabitSolutionsMvc.Models
{
    public class FeedbackForm
    {
        [StringLength(50, ErrorMessageResourceType = typeof(Translations), ErrorMessageResourceName = "StringLengthMaximum")]
        [Required(ErrorMessageResourceType = typeof(Translations), ErrorMessageResourceName = "NameLabel")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessageResourceType = typeof(Translations), ErrorMessageResourceName = "StringLengthMaximum")]
        [Required(ErrorMessageResourceType = typeof(Translations), ErrorMessageResourceName = "EmailLabel")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessageResourceType = typeof(Translations), ErrorMessageResourceName = "EmailValidation")]
        public string Email { get; set; }

        [Required(ErrorMessageResourceType = typeof(Translations), ErrorMessageResourceName = "MessageLabel")]
        [DataType(DataType.MultilineText)]
        public string Message { get; set; }

        [Required(ErrorMessageResourceType = typeof(Translations), ErrorMessageResourceName = "CaptchaEmptyField")]
        [Range(0, 1000, ErrorMessageResourceType = typeof(Translations), ErrorMessageResourceName = "CaptchaRange")]
        public string Captcha { get; set; } 
    }
        
}
