using Type = MangaDexApiWrapper.Basic.Models.Enums.Type;

namespace MangaDexApiWrapper.Basic.Models.EntityModels;

public class CustomList
{
    public string Id { get; set; }
    public Type Type { get; set; }
    public CustomListAttributes CustomListAttributes { get; set; }
    public Relationships Relationships { get; set; }
}