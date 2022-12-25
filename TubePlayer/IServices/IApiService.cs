
namespace TubePlayer.IServices
{
    public interface IApiService
    {
        //Interface Method for Searching Videoes
        Task<VideoSearchResult> SearchVideoes(string searchQuery, string nextPageToken = "");
    }
}
