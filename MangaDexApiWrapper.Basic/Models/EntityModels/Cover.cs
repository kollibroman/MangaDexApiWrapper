using Type = MangaDexApiWrapper.Basic.Models.Enums.Type;

namespace MangaDexApiWrapper.Basic.Models.EntityModels;

public class Cover
{
    public string Id { get; set; }
    public Type Type { get; set; }
    public CoverAttributes Attributes { get; set; }
    public Relationships Relationships { get; set; }
}