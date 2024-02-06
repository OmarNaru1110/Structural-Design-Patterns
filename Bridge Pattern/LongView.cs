using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    internal class LongView:IViewResource
    {
        public LongView(IMediaResource mediaResource) : base(mediaResource)
        {
        }

        public override void Show()
        {
            Console.WriteLine("======== Long View ========");
            Console.WriteLine(MediaResource.GetSummary());
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");
            Console.WriteLine("======== Long View ========");

        }
    }
}
