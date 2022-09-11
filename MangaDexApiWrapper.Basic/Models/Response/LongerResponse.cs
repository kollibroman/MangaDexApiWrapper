namespace MangaDexApiWrapper.Basic.Models.Response;

public class LongerResponse<T> : NormalResponse<T>
{
    public int Limit { get; set; }
    public int Offset { get; set; }
    public int Total { get; set; }
}