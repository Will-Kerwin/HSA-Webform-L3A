using System.Net.Http.Json;

namespace HSA.Client.Services
{

    public interface IAuthHttpService
    {
        Task Get<T>(string uri) where T : class;
        Task Post<T>(string uri) where T : class;
        Task Put<T>(string uri) where T : class;
        Task Patch<T>(string uri) where T : class;
        Task<string> GetToken();
    }
    public class AuthHttpService : IAuthHttpService
    {
        public ILocalStorageService LocalStorage { get; }
        public HttpClient Client { get; }

        public AuthHttpService(ILocalStorageService localStorage, HttpClient client)
        {
            LocalStorage = localStorage;
            Client = client;
            string token = GetToken().Result;
            Client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }

        public Task<string> GetToken()
        {
            return Task.Run(async () => {
                string token = await LocalStorage.GetItem<string>("token");
                return token == null ? throw new NoTokenFound("token does not exist") : token;
            });
        }

        public Task Get<T>(string uri) where T : class
        {
            return Client.GetFromJsonAsync<T>(uri);        

        }

        public Task Patch<T>(string uri) where T : class
        {
            throw new NotImplementedException();
        }

        public Task Post<T>(string uri) where T : class
        {
            throw new NotImplementedException();
        }

        public Task Put<T>(string uri) where T : class
        {
            throw new NotImplementedException();
        }
    }

    public class NoTokenFound : Exception
    {
        public NoTokenFound(string message) : base(message)
        {

        }
    }
}
