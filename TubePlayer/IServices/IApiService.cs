
namespace TubePlayer.IServices
{
    public interface IApiService
    {
        //Method for Searching Videoes
        Task<VideoSearchResult> SearchVideoes(string searchQuery, string nextPageToken = "");
    }
}
