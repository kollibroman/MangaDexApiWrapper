using MangaDexApiWrapper.Basic.Config;
using MangaDexApiWrapper.Basic.Enums;
using MangaDexApiWrapper.Basic.Objects;

namespace MangaDexApiWrapper.Basic.RequestQueryBuilders;

public class MangaQueryBuilder
{
   private readonly HttpClientConfig _clientConfig;

   public MangaQueryBuilder(HttpClientConfig clientConfig)
   {
        _clientConfig = clientConfig;
   }   

   public async Task CreateGetMangaListAsync(int limit, int offset, string title, string authorOrArtist, string[] authors, string[] artists, int year, 
                                string[] includedTags, IncludedTagsMode includedTagsMode, string[] excludedTags, ExcludedTagsMode excludedTagsMode, Status[] status, string[] originalLanguage,
                                string[] excludedOriginalLanguage, string[] availableTranslatedLanguage, PublicationDemographic[] publicationDemographic, string[] ids, ContentRating[] contentRating,
                                string createdAtSince, string updatedAtSince, Order order, Includes[] includes, HasAvailableChapters hasAvailableChapters, string group)
   {
        
   }
}