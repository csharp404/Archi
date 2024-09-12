using System.ComponentModel.DataAnnotations;

namespace RESProject.Models.ViewModels.UserVms
{
    public class LoginVM
    {
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; } = false;
    }
}
