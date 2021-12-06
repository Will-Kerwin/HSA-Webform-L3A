using Fluxor;

namespace HSA.Client.Store.AuthUseCase
{
    public class Feature : Feature<AuthState>
    {
        public override string GetName() => "Auth State";

        protected override AuthState GetInitialState() =>
            new AuthState(
                    iD: Guid.Empty,
                    firstName: "",
                    lastName:"",
                    isAuthenticated: false,
                    trade:"",
                    dateOfBirth: DateTime.MinValue,
                    role: ""
                );
    }
}
