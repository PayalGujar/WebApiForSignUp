using Dapper;
using WebApiForSignUp.Data;
using WebApiForSignUp.Models;
using System.Data;

namespace WebApiForSignUp.Repositories
{
    public class UserRepo : IUserRepo
    {
        private readonly ApplicationDbContext context;

        public UserRepo(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<int> AddUser(User user)
        {
            int result = 0;
            var parameters =new  DynamicParameters();
            parameters.Add("@Name", user.Name);
            parameters.Add("@AdharCard", user.AdharCard);
            parameters.Add("@PanCard", user.PanCard);
            parameters.Add("@DOB", user.DOB);
            parameters.Add("@Mobile_No", user.MobileNumber);
            parameters.Add("@age", user.age);
            parameters.Add("@city", user.City);
            parameters.Add("@state", user.State);
            parameters.Add("@Uimage", user.UImage);
            using (var connection =context.CreateConnection())
            {
                result = await connection.ExecuteAsync("SP_SignUp_InsertSignUp", parameters, commandType:CommandType.StoredProcedure);
            }
            return result;

        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            using (var connection =context.CreateConnection())
            {
                var result=await connection.QueryAsync<User>(" SP_Display_SignUp", commandType:CommandType.StoredProcedure);
                return result.ToList();
            }
        }
    }
}
