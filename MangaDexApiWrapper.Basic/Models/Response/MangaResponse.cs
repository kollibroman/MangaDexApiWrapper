namespace MangaDexApiWrapper.Basic.Models.Response;

public class MangaResponse
{
    public string Result { get; set; }
    public string Response { get; set; }
    public List<Manga> data { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public int Total { get; set; }
}