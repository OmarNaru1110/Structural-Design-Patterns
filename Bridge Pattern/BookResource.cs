using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    internal class BookResource : IMediaResource
    {
        Book book;
        public BookResource(Book book)
        {

            this.book = book;

        }
        public string GetSummary()
        {
            return book.Title;
        }
    }
}
