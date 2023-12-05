using WebApiForSignUp.Models;

namespace WebApiForSignUp.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetUsers();
        Task<int> AddUser(User user);
    }
}
