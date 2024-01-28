using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.YoutubeCaching_Ex
{
    public class YoutubeManager
    {
        private readonly IYoutubeService _youtubeServiceProxy;//the proxy
        public YoutubeManager(IYoutubeService youtubeServiceProxy)
        {
            _youtubeServiceProxy = youtubeServiceProxy;
        }
        public string DownloadVideo(int id)
        {
            return _youtubeServiceProxy.DownloadVideo(id);
        }

        public string GetVideoInfo(int id)
        {
            return _youtubeServiceProxy.GetVideoInfo(id);

        }

        public string ListVideos()
        {
            return _youtubeServiceProxy.ListVideos();

        }
    }
}
