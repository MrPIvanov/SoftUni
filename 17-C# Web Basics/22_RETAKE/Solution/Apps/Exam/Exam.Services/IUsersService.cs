using Exam.Data.Models;

namespace Exam.Services
{
    public interface IUsersService
    {
        string CreateUser(string username, string email, string password);

        User GetUserOrNull(string username, string password);
    }
}
