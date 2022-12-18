
namespace TubePlayer.IServices
{
    public interface IApiService
    {
        Task<VideoSearchResult> SearchVideoes(string searchQuery, string nextPageToken = "");
    }
}
