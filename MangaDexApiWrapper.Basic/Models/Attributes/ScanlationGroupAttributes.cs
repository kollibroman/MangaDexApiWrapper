
namespace MangaDexApiWrapper.Basic.Models;

public class ScanlationGroupAttributes
{
    public string Name { get; set; }
    public string AltNames { get; set; }
    public string Website { get; set; }
    public string IrcServer { get; set; }
    public string IrcChannel { get; set; }
    public string Discord { get; set; }
    public string ContactEmail { get; set; }
    public string Description { get; set; }
    public string Twitter { get; set; }
    public string MangaUpdates { get; set; }
    public string[] FocusedLanguage { get; set; }
    public bool Locked { get; set; }
    public bool Official { get; set; }
    public bool Inactive { get; set; }
    public string PublishDelay { get; set; }
    public int Version { get; set; }
    public string CreatedAt { get; set; }
    public string UpdatedAt { get; set; }
}