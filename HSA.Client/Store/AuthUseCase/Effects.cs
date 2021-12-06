using HSA.Client.Services;
using MudBlazor;

namespace HSA.Client.Store.AuthUseCase
{
    public class Effects
    {
        private readonly ILocalStorageService localStorage;
        private readonly ILogger logger;
        private readonly ISnackbar snackbar;

        public Effects(ILocalStorageService localStorage, ILogger logger, ISnackbar snackbar)
        {
            this.localStorage = localStorage;
            this.logger = logger;
            this.snackbar = snackbar;
        }
    }
}
