namespace MangaDexApiWrapper.Basic.Models;

public class UploadSessionAttributes
{
    public bool IsCommited { get; set; }
    public bool IsProcessed { get; set; }
    public bool IsDeleted { get; set; }
    public int Version { get; set; }
    public string CreatedAt { get; set; }
    public string UpdatedAt { get; set; }
}