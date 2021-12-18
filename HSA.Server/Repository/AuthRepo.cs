using HSA.Shared.Models.User;
using Dapper;
using System.Data.SqlClient;
using HSA.Server.Exceptions.Auth;

namespace HSA.Server.Repository
{
    public class AuthRepo : IAuthRepo
    {
        private readonly IConfiguration configuration;

        public AuthRepo(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public Task<string> GenerateToken(UserModel user)
        {
            return Task.FromResult("Token");
        }

        public async Task<UserModel> LoginUser(LoginModel data)
        {
            using var con = new SqlConnection(configuration.GetConnectionString("HSADB"));
            var userResult = await con.QueryFirstOrDefaultAsync<UserModel>(
                    @"SELECT * FROM utbl_Auth_Users WHERE EmployeeID = @EMPID;",
                    new
                    {
                        EMPID = data.EmployeeNo
                    },
                    commandType: System.Data.CommandType.Text
                );
            if (userResult.EmployeeNo == 0)
                throw new EmployeeNotFoundException("No Employee found with this ID");
            else if (BCrypt.Net.BCrypt.Verify(data.Password, userResult.Password))
                throw new IncorrectPasswordException("The password is incorrect");
            else
                return new UserModel()
                {
                    Email = userResult.Email,
                    Id = userResult.Id,
                    FirstName = userResult.FirstName,
                    LastName = userResult.LastName,
                    Role = userResult.Role,
                    DateOfBirth = userResult.DateOfBirth,
                    EmployeeNo = userResult.EmployeeNo,
                    Trade = userResult.Trade
                };
        }

        public Task<UserModel> RegisterNewEmployee()
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> RegisterUser()
        {
            throw new NotImplementedException();
        }
    }
}
