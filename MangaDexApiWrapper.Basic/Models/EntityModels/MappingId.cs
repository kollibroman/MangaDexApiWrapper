using Type = MangaDexApiWrapper.Basic.Models.Enums.Type;

namespace MangaDexApiWrapper.Basic.Models.EntityModels;

public class MappingId
{
    public string Id { get; set; }
    public Type Type { get; set; }
    public MappingIdAttributes Attributes { get; set; }
    public Relationships Relationships { get; set; }
}