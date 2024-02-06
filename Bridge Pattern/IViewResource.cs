using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    internal abstract class IViewResource
    {
        public IMediaResource MediaResource { get; set; }
        public IViewResource(IMediaResource mediaResource)
        {
            MediaResource = mediaResource;
        }
        public virtual void Show() {}
    }
}
