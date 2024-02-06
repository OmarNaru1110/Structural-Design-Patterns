namespace Bridge_Pattern
{
    internal class Program
    {
        /*
        Bridge pattern is decoupling the interface from it's concretions so that 
        we can avoid class explosion scenarios

        url of my explanation video: https://www.linkedin.com/feed/update/urn:li:activity:7160603276269301760/

        I created an explanation video for this one cuz explaining it was so hard 
        */
        static void Main(string[] args)
        {
            Artist artist = new Artist { Bio = "any bio" };
            var artistResource = new ArtistResource(artist);

            var shortView = new ShortView(artistResource);
            shortView.Show();
            Console.WriteLine();
            var longView = new LongView(artistResource);
            longView.Show();
        }
    }
}
