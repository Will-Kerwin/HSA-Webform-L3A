using HSA.Shared.Models.User;

namespace HSA.Client.Store.AuthUseCase.Actions
{

    public class LoginUserAction
    {
        public LoginModel Data { get; }

        public LoginUserAction(LoginModel data)
        {
            Data = data;
        }
    }
}
