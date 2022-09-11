using MangaDexApiWrapper.Basic.Models.EntityModels;

namespace MangaDexApiWrapper.Basic.Models.Response;

public class GroupResponse
{
    public string Result { get; set; }
    public string Response { get; set; }
    public ScanlationGroup Data { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
    public int Total { get; set; }
}