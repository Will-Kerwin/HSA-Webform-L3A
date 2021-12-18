using Fluxor;
using HSA.Client.Store.AuthUseCase.Actions;
using HSA.Client.Store.FormUseCase;

namespace HSA.Client.Store.AuthUseCase
{
    public class Reducers
    {

        [ReducerMethod]
        public static AuthState ReduceLoginUserAction(AuthState state, LoginUserAction action) =>
            new AuthState(
                    isLoading: true,
                    isAuthenticated: state.IsAuthenticated,
                    user: state.User
                );

        [ReducerMethod]
        public static AuthState ReduceLoginUserActionResult(AuthState state, LoginUserActionResult action) =>
            new AuthState(
                    isLoading: false,
                    isAuthenticated: action.IsAuthenticated,
                    user: action.User
                );

    }
}
