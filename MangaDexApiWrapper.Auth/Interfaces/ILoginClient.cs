using System;
using MangaDexApiWrapper.Auth.Response;

namespace MangaDexApiWrapper.Auth.Interfaces
{
    public interface ILoginClient
    {
        public Task<LoginResponse> LoginPostRequestAsync(string username, string password);
        public Task<CheckResponse> CheckTokenAsync();
        public Task<LoginResponse> RefreshAsync();
    }
}
