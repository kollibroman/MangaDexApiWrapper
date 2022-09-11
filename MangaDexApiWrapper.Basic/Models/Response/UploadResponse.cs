using Type = MangaDexApiWrapper.Basic.Models.Enums.Type;

namespace MangaDexApiWrapper.Basic.Models.Response;

public class UploadResponse
{
    public string Id { get; set; }
    public Type Type { get; set; }
    public UploadSessionAttributes Attributes { get; set; }
}