using SMS.Models;

namespace SMS.Services
{
    public interface IUsersService
    {
        string CreateUser(string username, string email, string password);

        User GetUserOrNull(string id);
        User GetUserOrNullWithUsernameAndPassword(string username, string password);
    }
}