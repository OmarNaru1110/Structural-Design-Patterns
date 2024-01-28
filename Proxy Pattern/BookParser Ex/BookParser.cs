using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.BookParser_Ex
{
    public class BookParser : IBookParser
    {
        private string parser;
        public BookParser(string str)
        {
            Thread.Sleep(3000);//consider this is a heavy operation
            parser = str;
        }
        public int GetNumParser()
        {
            return parser.Length;
        }
    }
}
