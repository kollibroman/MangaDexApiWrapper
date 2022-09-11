namespace MangaDexApiWrapper.Basic.Models.EntityModels;

public class ScanlationGroup
{
    public int Id { get; set; }
    public Type Type { get; set; }
    public ScanlationGroupAttributes Attributes { get; set; }
    public Relationships Relationships { get; set; }
}