using WebApiForSignUp.Models;

namespace WebApiForSignUp.Repositories
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetUsers();
        Task<int> AddUser(User user);
    }
}
