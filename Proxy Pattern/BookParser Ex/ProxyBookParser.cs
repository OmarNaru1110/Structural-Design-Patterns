using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.BookParser_Ex
{
    public class ProxyBookParser : IBookParser
    {
        private BookParser _bookParser;
        private string parser;
        public ProxyBookParser(string str)
        {
            parser = str;
        }
        public int GetNumParser()
        {
            if (_bookParser == null)
                _bookParser = new BookParser(parser);
            return _bookParser.GetNumParser();
        }
    }
}
