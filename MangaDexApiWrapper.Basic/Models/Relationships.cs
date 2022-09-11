using MangaDexApiWrapper.Basic.Models.Enums;

namespace MangaDexApiWrapper.Basic.Models;

public class Relationships
{
    public int Id { get; set; }
    public string Type { get; set; }
    public Related Related { get; set; }
    public Object Attributes { get; set; }
}