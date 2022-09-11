using MangaDexApiWrapper.Basic.Models.EntityModels;

namespace MangaDexApiWrapper.Basic.Models.Response;

public class ErrorResponse
{
    public string Result { get; set; }
    public Error Error { get; set; }
}