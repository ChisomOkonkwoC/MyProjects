using System.ComponentModel.DataAnnotations;

namespace Ecommerce.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="")]
       public  string Email { get; set; }

        [Required(ErrorMessage ="")]
       public  string Password { get; set; }
    }
}
