using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.YoutubeCaching_Ex
{
    public class YoutubeService : IYoutubeService
    {
        public string DownloadVideo(int id)
        {
            StringBuilder sb = new StringBuilder("Downloading");
            for(int i = 0; i < 10; i++)
            {
                sb.Append('.');
                Thread.Sleep(500);
            }
            return sb.ToString();
        }

        public string GetVideoInfo(int id)
        {
            return $"[{id}] video information...";
        }

        public string ListVideos()
        {
            return $"video 1" +
                    $"video 2" +
                    $"video 3" +
                    $"video 4";
        }
    }
}
