
using Maui.Apps.Framework.Services;
using MonkeyCache;
using TubePlayer.IServices;

namespace TubePlayer.Services
{
    public class YouTubeService : RestServiceBase, IApiService    {
        public YouTubeService(IConnectivity connectivity, IBarrel cacheBarrel): base(connectivity, cacheBarrel)
        {
            
        }
    }
}
