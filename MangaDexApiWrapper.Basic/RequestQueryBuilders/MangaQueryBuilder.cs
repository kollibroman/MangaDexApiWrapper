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

   
}