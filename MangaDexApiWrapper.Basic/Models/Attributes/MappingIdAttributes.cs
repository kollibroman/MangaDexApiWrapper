using Type = MangaDexApiWrapper.Basic.Models.Enums.Type;

namespace MangaDexApiWrapper.Basic.Models;

public class MappingIdAttributes
{
    public Type Type { get; set; }
    public int LegacyId { get; set; }
    public string NewId { get; set; }
}