using Exam.Data;
using Exam.Data.Models;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Exam.Services
{
    public class UsersService : IUsersService
    {
        private readonly ExamDbContext context;

        public UsersService(ExamDbContext context)
        {
            this.context = context;
        }

        public string CreateUser(string username, string email, string password)
        {
            //TODO Maybe check if user already exist

            var user = new User
            {
                Username = username,
                Email = email,
                Password = this.HashPassword(password)
            };

            this.context.Users.Add(user);
            this.context.SaveChanges();

            return user.Id;
        }

        public User GetUserOrNull(string username, string password)
        {
            var hashPassword = this.HashPassword(password);

            var user = this.context.Users
                            .SingleOrDefault(u => u.Username == username && u.Password == hashPassword);        //Maybe FirstOrDefaul()

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
