using Type = MangaDexApiWrapper.Basic.Models.Type;

namespace MangaDexApiWrapper.Basic.Models;

public class Manga
{
    public string Id { get; set; }
    public Type Type { get; set; }
    public MangaAttributes Attributes { get; set; }
    public Relationships Relationships { get; set; }
}