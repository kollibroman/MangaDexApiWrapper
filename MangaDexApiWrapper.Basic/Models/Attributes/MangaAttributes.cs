using MangaDexApiWrapper.Basic.Models.Enums;

namespace MangaDexApiWrapper.Basic.Models;

public class MangaAttributes
{
    public string Title { get; set; }
    public string AltTitles { get; set; }
    public string Description { get; set; }
    public bool IsLocked { get; set; }
    public object Links { get; set; }
    public string OriginalLanguage { get; set; }
    public string LastVolume { get; set; }
    public string LastChapter { get; set; }
    public PublicationDemographic PublicationDemographic { get; set; }
    public Status Status { get; set; }
    public int Year { get; set; }
    public ContentRating ContentRating { get; set; }
    public bool ChapterNumbersResetOnNewVolume { get; set; }
    public string[] AvailableTranslatedLanguages { get; set; }
    public State State { get; set; }
    public int Version { get; set; }
    public string CreatedAt { get; set; }
    public string UpdatedAt { get; set; }
}