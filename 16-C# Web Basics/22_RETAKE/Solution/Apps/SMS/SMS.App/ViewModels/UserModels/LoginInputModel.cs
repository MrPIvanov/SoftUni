using SIS.MvcFramework.Attributes.Validation;

namespace SMS.App.ViewModels.UserModels
{
    public class LoginInputModel
    {
        private const string UsernameErroeMsg = "Username should be between 5 and 20 characters";
        private const string PasswordErroeMsg = "Username should be between 6 and 20 characters";


        [RequiredSis]
        [StringLengthSis(5, 20, UsernameErroeMsg)]
        public string Username { get; set; }

        [RequiredSis]
        [StringLengthSis(6, 20, PasswordErroeMsg)]
        public string Password { get; set; }
    }
}
