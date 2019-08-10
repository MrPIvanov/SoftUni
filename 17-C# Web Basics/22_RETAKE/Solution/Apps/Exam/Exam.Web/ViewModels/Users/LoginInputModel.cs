using SIS.MvcFramework.Attributes.Validation;

namespace Exam.Web.ViewModels.Users
{
    public class LoginInputModel
    {
        [RequiredSis]
        [StringLengthSis(5, 20, "Username should be between 5 and 20 chars.")]  //TODO Check if needed
        public string Username { get; set; }

        [RequiredSis]
        [StringLengthSis(5, 20, "Password should be between 5 and 20 chars.")]
        public string Password { get; set; }

    }
}
