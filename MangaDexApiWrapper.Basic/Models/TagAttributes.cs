namespace MangaDexApiWrapper.Basic.Models;

public class TagAttributes
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Group { get; set; }
    public int Version { get; set; }
    public Relationships Relationships { get; set; }
}