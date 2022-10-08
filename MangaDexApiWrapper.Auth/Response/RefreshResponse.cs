using MangaDexApiWrapper.Auth.EntityModels;
using MangaDexApiWrapper.Basic.Models.Enums;

namespace MangaDexApiWrapper.Auth.Response
{
    public class RefreshResponse
    {
        public Result Result { get; set; }
        public Token Token { get; set; }
        public string Message { get; set; }
    }
}