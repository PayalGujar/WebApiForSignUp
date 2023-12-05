using Microsoft.Data.SqlClient;
using System.Data;
namespace WebApiForSignUp.Data
{
    public class ApplicationDbContext
    {
        private readonly IConfiguration configuration;
        private readonly string connectionstring;

        public ApplicationDbContext(IConfiguration configuration)
        {
            this.configuration = configuration;
            connectionstring = configuration.GetConnectionString("defaultConnection");
        }
        public IDbConnection CreateConnection()=>new SqlConnection(connectionstring);
    }
}
