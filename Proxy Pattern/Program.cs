using Proxy_Pattern.BookParser_Ex;
using Proxy_Pattern.YoutubeCaching_Ex;
using System.Diagnostics;

namespace Proxy_Pattern
{
    internal class Program
    {
        /*
            there're a lot of purposes to use the proxy pattern
            like caching, protection, local access to a remote resource,etc
            in this example we gonna use proxy, but for what?
            let's say we have a class BookParser that the instantiation of it
            is heavy, but using it's methods is kinda cheap,
            the problem is we need multiple instances of book parser but we 
            won't gonna use their methods
            so what we can do here is to create IBookParser interface
            and make BookParser implements it, and we create another class 
            called ProxyBookParser that implements that interface
            and instead of instantiating BookParser objs, we gonna use the proxy
            so what's gonna happen inside proxy is, instead of instantiating
            BookParser objs, we won't do that untill the client needs 
            any of it's methods, which is LAZY LOADING
            you gonna think, why the hassle with creating new class?
            why don't we do the proxy functionality inside the BookParser class
            cuz what if the BookParser class is a 3rd party library that we don't have
            control over it? so we won't be able to edit it's code, right?
            SO THAT WAS THE FIRST EX.
            LET'S CONTINUE TO THE SECOND EX.... WHICH IS 3RD PARTY YOUTUBE LIBRARY
            ---------------> let's say we have 3rd party youtube class 
            that's can 
            1. list youtube home videos
            2. download video via videoId
            3. get video info. via videoId
            but all these operation are heavy cuz the requests will go first
            to the application server, then the server will forward it to 
            youtube server like that
            the problem is, what if we just wanted to download the same video
            multiple times or something like that
            do i need to always make that long trip?
            here comes the proxy pattern that will cache the results
            in it's own fields
        */
        static void Main(string[] args)
        {
            #region BookParser
/*            //it didn't inistantiate any bookparser objs
            IBookParser bookParser = new ProxyBookParser("لا إله إلا الله");

            //now it instantiates it
            int result = bookParser.GetNumParser();
            Console.WriteLine(result);*/
            #endregion

            #region YoutubeService
            IYoutubeService realYoutubeService= new YoutubeService();
            IYoutubeService proxy = new CachedYoutubeService(realYoutubeService);
            YoutubeManager manager = new YoutubeManager(proxy);
            
            Stopwatch st = new Stopwatch();
            while (true)
            {
                Console.WriteLine("[1] List Videos\n[2] Get Video\n[3] Download Video");
                int.TryParse(Console.ReadLine(), out int num);
                switch(num)
                {
                    case 1:
                        st.Start();
                        Console.WriteLine(manager.ListVideos());
                        st.Stop();
                        Console.WriteLine(st.ElapsedMilliseconds);
                        Console.WriteLine("============================");
                        break;
                    case 2:
                        int id = int.Parse(Console.ReadLine());
                        st.Start();
                        Console.WriteLine(manager.GetVideoInfo(id));
                        st.Stop();
                        Console.WriteLine(st.ElapsedMilliseconds);
                        Console.WriteLine("============================");
                        break;
                    case 3:
                        int id2 = int.Parse(Console.ReadLine());
                        st.Start();
                        Console.WriteLine(manager.DownloadVideo(id2));
                        st.Stop();
                        Console.WriteLine(st.ElapsedMilliseconds);
                        Console.WriteLine("============================");
                        break;
                    default:
                        break;
                }
            }
            
            #endregion
        }
    }
}
