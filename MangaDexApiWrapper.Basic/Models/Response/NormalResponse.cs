namespace MangaDexApiWrapper.Basic.Models.Response;

public class NormalResponse<T>
{
    public string Result { get; set; }
    public string Response { get; set; }
    public T Data { get; set; }
}