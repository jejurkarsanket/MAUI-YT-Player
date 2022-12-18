
using Maui.Apps.Framework.Services;
using MonkeyCache;
using System.Net;
using TubePlayer.IServices;

namespace TubePlayer.Services
{
    public class YouTubeService : RestServiceBase, IApiService    
    {
        public YouTubeService(IConnectivity connectivity, IBarrel cacheBarrel): base(connectivity, cacheBarrel)
        {
            SetBaseURL(Constants.ApiServiceURL);
        }

        public async Task<VideoSearchResult> SearchVideoes(string searchQuery, string nextPageToken = "")
        {
            var resourceUri = $"search?part=snippet&maxResults=10&type=video&key={Constants.ApiKey}&q={WebUtility.UrlEncode(searchQuery)}"
                +
                (!string.IsNullOrEmpty(nextPageToken)? $"&pageToken={nextPageToken}" : "");

            var result = await GetAsync<VideoSearchResult>(resourceUri, 4);
            return result;
        }
    }
}
