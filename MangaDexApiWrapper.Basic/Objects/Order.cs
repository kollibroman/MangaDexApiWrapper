using MangaDexApiWrapper.Basic.Enums;

namespace MangaDexApiWrapper.Basic.Objects
{
    public class Order
    {
        public Title Title { get; set; }
        public Year Year { get; set; }
        public CreatedAt CreatedAt { get; set; }
        public UpdatedAt UpdatedAt { get; set; }
        public LatestUploadedChapter LatestUploadedChapter { get; set; }
        public FollowedCount FollowedCount { get; set; }
        public Relevance Relevance { get; set; }
        public Rating Rating { get; set; }
    }
}