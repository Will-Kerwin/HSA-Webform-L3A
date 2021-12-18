using Fluxor;
using HSA.Client.Services;
using HSA.Client.Store.AuthUseCase.Actions;
using HSA.Shared.Models.User;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Net.Http.Json;

namespace HSA.Client.Store.AuthUseCase
{
    public class Effects
    {
        private readonly ILocalStorageService localStorage;
        private readonly ILogger logger;
        private readonly ISnackbar snackbar;
        private readonly NavigationManager NavMgr;
        private readonly IConfiguration config;

        public Effects(ILocalStorageService localStorage, ILogger logger, ISnackbar snackbar, NavigationManager navMgr,IConfiguration configuration)
        {
            this.localStorage = localStorage;
            this.logger = logger;
            this.snackbar = snackbar;
            NavMgr = navMgr;
            config = configuration;
        }

        [EffectMethod]
        public async Task HandleLoginData(LoginUserAction action, IDispatcher dispatcher)
        {
            HttpClient client = new HttpClient();
            var res = await client.PostAsJsonAsync($"{config["HSAPI"]}/login", action.Data);
            if (res.IsSuccessStatusCode) 
            {
                (UserModel User, string Token) data = await res.Content.ReadFromJsonAsync<(UserModel User, string Token)>();
                await localStorage.SetItem<string>("token", data.Token);
                dispatcher.Dispatch(new LoginUserActionResult(data.User, true));
                NavMgr.NavigateTo("/home");
            }
            else
            {
                dispatcher.Dispatch(new LoginUserActionResult(new UserModel(), false));
                NavMgr.NavigateTo("/");
                snackbar.Add(await res.Content.ReadAsStringAsync(), Severity.Error);
            }
        }
    }
}
