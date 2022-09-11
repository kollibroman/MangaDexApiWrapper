namespace MangaDexApiWrapper.Basic.Models.Response;

public class ChapterResponse
{
    public string Result { get; set; }
    public string response { get; set; }
    public Chapter Data { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public int Total { get; set; }
}