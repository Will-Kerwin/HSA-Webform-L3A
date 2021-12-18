using HSA.Shared.Models.User;

namespace HSA.Client.Store.AuthUseCase
{
    public class AuthState
    {
        public AuthState(bool isAuthenticated, UserModel user, bool isLoading)
        {
            IsAuthenticated = isAuthenticated;
            User = user;
            IsLoading = isLoading;
        }

        public UserModel User { get; }
        public bool IsAuthenticated { get; }
        public bool IsLoading { get; }
    }
}
