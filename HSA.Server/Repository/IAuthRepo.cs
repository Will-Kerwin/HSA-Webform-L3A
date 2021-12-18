using HSA.Shared.Models.User;

namespace HSA.Server.Repository
{
    public interface IAuthRepo
    {
        Task<UserModel> LoginUser(LoginModel data);
        Task<UserModel> RegisterUser();
        Task<UserModel> RegisterNewEmployee();
        Task<string> GenerateToken(UserModel user);
    }
}
