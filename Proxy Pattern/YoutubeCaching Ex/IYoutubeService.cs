using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.YoutubeCaching_Ex
{
    public interface IYoutubeService
    {
        string ListVideos();
        string GetVideoInfo(int id);
        string DownloadVideo(int id);
    }
}
