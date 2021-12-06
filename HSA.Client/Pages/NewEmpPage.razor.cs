using Fluxor;
using HSA.Client.Store.AuthUseCase;
using HSA.Client.Store.FormUseCase;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HSA.Client.Pages
{
    public partial class NewEmpPage
    {

        [Inject]
        private IState<FormState> FormState { get; set; }

        [Inject]
        public IDispatcher Dispatcher { get; set; }

        [Inject]
        public IState<AuthState> AuthState { get; set; }

        [Inject]
        public NavigationManager navMgr { get; set; }

        [Inject]
        public ISnackbar Snackbar { get; set; }

        // on component load if authenticated redirect to correct workflow
        protected override void OnInitialized()
        {
            if (AuthState.Value.IsAuthenticated)
            {
                Snackbar.Add("Redirecting to correct form!", Severity.Normal);
                navMgr.NavigateTo($"/{AuthState.Value.Role}");
            }
            base.OnInitialized();
        }
    }
}
