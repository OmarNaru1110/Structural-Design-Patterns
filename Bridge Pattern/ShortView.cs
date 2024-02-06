using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    internal class ShortView:IViewResource
    {
        public ShortView(IMediaResource mediaResource) : base(mediaResource)
        {
        }

        public override void Show()
        {
            Console.WriteLine("======== Short View ========");
            Console.WriteLine(MediaResource.GetSummary());
            Console.WriteLine("============================");
        }
    }
}
