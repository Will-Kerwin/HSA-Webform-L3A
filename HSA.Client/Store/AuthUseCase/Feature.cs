using Fluxor;

namespace HSA.Client.Store.AuthUseCase
{
    public class Feature : Feature<AuthState>
    {
        public override string GetName() => "Auth State";

        protected override AuthState GetInitialState() =>
            new AuthState(
                    isAuthenticated: false,
                    user: new HSA.Shared.Models.User.UserModel()
                );
    }
}
