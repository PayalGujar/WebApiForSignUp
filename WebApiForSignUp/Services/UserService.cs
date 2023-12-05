using WebApiForSignUp.Models;
using WebApiForSignUp.Repositories;

namespace WebApiForSignUp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepo repo;

        public UserService(IUserRepo repo)
        {
            this.repo = repo;
        }

        public async Task<int> AddUser(User user)
        {
           return await repo.AddUser(user);
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
           return await repo.GetUsers();
        }
    }
}
