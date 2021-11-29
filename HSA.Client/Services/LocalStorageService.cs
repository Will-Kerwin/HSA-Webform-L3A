using Microsoft.JSInterop;
using System.Text.Json;

namespace HSA.Client.Services
{

    public interface ILocalStorageService
    {
        Task<T> GetItem<T>(string key);
        Task SetItem<T>(string key, T value);
        Task RemoveItem(string key);
    }

    /// <summary>
    /// Abstraction of js interop allowing saving data to local storage
    /// </summary>
    public class LocalStorageService : ILocalStorageService
    {
        private IJSRuntime JSRuntime;

        public LocalStorageService(IJSRuntime jsRuntime)
        {
            JSRuntime = jsRuntime;
        }

        public async Task<T> GetItem<T>(string key)
        {
            string data = await JSRuntime.InvokeAsync<string>("localStorage.getItem", key);

            if (data == null)
                return default!;

            return JsonSerializer.Deserialize<T>(data)!;
        }

        public async Task RemoveItem(string key)
        {
            await JSRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }

        public async Task SetItem<T>(string key, T value)
        {
            await JSRuntime.InvokeVoidAsync("localStorage.setItem", key, JsonSerializer.Serialize(value));
        }
    }
}
