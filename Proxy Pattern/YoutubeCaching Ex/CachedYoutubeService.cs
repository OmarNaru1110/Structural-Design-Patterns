using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.YoutubeCaching_Ex
{
    //Proxy
    public class CachedYoutubeService : IYoutubeService
    {
        private readonly IYoutubeService _youtubeService;
        public CachedYoutubeService(IYoutubeService youtubeService)
        {
            _youtubeService = youtubeService;
        }
        Dictionary<int, string> VideosInfoCache = new Dictionary<int, string>();
        Dictionary<int, string> VideosDownloadCache = new Dictionary<int, string>();
        public string listVideos;

        public string DownloadVideo(int id)
        {
            //check the cache first
            VideosDownloadCache.TryGetValue(id, out var video);
            //if was found? return it 
            if(video != null)
                return video;
            //not found? request it, then add it to the cache, then return it
            var downloadedVideo = _youtubeService.DownloadVideo(id);
            VideosDownloadCache.Add(id, downloadedVideo);
            return downloadedVideo;
        }

        public string GetVideoInfo(int id)
        {
            VideosInfoCache.TryGetValue(id, out var info);
            if (info != null)
                return info;
            var newInfo = _youtubeService.GetVideoInfo(id);
            VideosInfoCache[id]= newInfo;
            return newInfo;
        }

        public string ListVideos()
        {
            if(listVideos== null)
                listVideos=_youtubeService.ListVideos();
            return listVideos;
        }
    }
}
