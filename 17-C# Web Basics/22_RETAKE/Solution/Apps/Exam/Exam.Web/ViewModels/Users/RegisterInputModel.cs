using SIS.MvcFramework.Attributes.Validation;

namespace Exam.Web.ViewModels.Users
{
    public class RegisterInputModel
    {
        [RequiredSis]
        [StringLengthSis(5, 20, "Username should be between 5 and 20 chars.")]
        public string Username { get; set; }

        [RequiredSis]
        [StringLengthSis(5, 20, "Email should be between 5 and 20 chars.")]
        public string Email { get; set; }

        [RequiredSis]
        [StringLengthSis(5, 20, "Password should be between 5 and 20 chars.")]
        public string Password { get; set; }

        [RequiredSis]
        [StringLengthSis(5, 20, "Confirm Password should be between 5 and 20 chars.")]
        public string ConfirmPassword { get; set; }

    }
}
