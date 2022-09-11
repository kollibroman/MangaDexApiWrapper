namespace MangaDexApiWrapper.Basic.Models;

public class Chapter
{
    public int Id { get; set; }
    public Type Type { get; set; }
    public ChapterAttributes Attributes { get; set; }
    public Relationships Relationships { get; set; }
}