using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    internal class ArtistResource : IMediaResource
    {
        Artist artist;
        public ArtistResource(Artist artist)
        {
            this.artist = artist;
        }
        public string GetSummary()
        {
            return artist.Bio;
        }
    }
}
