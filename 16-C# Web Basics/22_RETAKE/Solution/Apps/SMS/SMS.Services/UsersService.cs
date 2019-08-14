using SMS.Data;
using SMS.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SMS.Services
{
    public class UsersService : IUsersService
    {
        private readonly SMSContext db;

        public UsersService(SMSContext db)
        {
            this.db = db;
        }

        public string CreateUser(string username, string email, string password)
        {
            // TODO: Check if user with the same username exists


            var user = new User
            {
                Username = username,
                Email = email,
                Password = this.HashPassword(password),
            };


            var cart = new Cart
            {
                User = user,
                UserId = user.Id,            
            };

            user.CartId = cart.Id;
            

            
            this.db.Carts.Add(cart);
            this.db.Users.Add(user);
            this.db.SaveChanges();
            return cart.User.Id;
        }

        public User GetUserOrNull(string id)
        {
            var user = this.db.Users.FirstOrDefault(
                x => x.Id == id);

            return user;
        }

        public User GetUserOrNullWithUsernameAndPassword(string username, string password)
        {
            var passwordHash = this.HashPassword(password);
            var user = this.db.Users.FirstOrDefault(
                x => x.Username == username
                && x.Password == passwordHash);
            return user;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return Encoding.UTF8.GetString(sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password)));
            }
        }
    }
}
