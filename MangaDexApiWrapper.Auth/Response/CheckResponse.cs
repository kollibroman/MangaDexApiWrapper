using MangaDexApiWrapper.Basic.Models.Enums;

namespace MangaDexApiWrapper.Auth.Response
{
    public class CheckResponse
    {
        public Result Result { get; set; }
        public bool isAuthenticated { get; set; }
        public string[] Roles { get; set; }
        public string[] Permissions { get; set; }
    }
}