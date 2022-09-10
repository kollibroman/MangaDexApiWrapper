namespace MangaDexApiWrapper.Basic.Models.Request;

public class AuthRequest
{
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
}