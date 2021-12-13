using Fluxor;
using HSA.Client;
using HSA.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<ILocalStorageService, LocalStorageService>();

builder.Services.AddHttpClient<AuthHttpService>(c =>
{
    c.BaseAddress = new Uri("https://localhost:7070");
});

builder.Services.AddMudServices();

var currentAssembly = typeof(App).Assembly;
builder.Services.AddFluxor(options =>
options
.ScanAssemblies(currentAssembly)
.UseRouting()
.UseReduxDevTools()
);

await builder.Build().RunAsync();
