using SIS.MvcFramework.Attributes.Validation;

namespace SMS.App.ViewModels.UserModels
{
    public class RegisterInputModel
    {
        private const string UsernameErroeMsg = "Username should be between 5 and 20 characters";
        private const string PasswordErroeMsg = "Username should be between 6 and 20 characters";

        [RequiredSis]
        [StringLengthSis(5, 20, UsernameErroeMsg)]
        public string Username { get; set; }


        [RequiredSis]
        [EmailSis]
        public string Email { get; set; }

        [RequiredSis]
        [StringLengthSis(6, 20, PasswordErroeMsg)]
        public string Password { get; set; }

        [RequiredSis]
        public string ConfirmPassword { get; set; }
    }
}
