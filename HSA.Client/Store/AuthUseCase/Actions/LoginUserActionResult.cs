using HSA.Shared.Models.User;

namespace HSA.Client.Store.AuthUseCase.Actions
{
    public class LoginUserActionResult
    {
        public UserModel User { get; }
        public bool IsAuthenticated { get; }

        public LoginUserActionResult(UserModel user, bool isAuthenticated)
        {
            User = user;
            IsAuthenticated = isAuthenticated;
        }
    }
}
