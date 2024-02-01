using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    internal class Class3
    {
        public Class2 class2;
        public Class3()
        {
            class2 = new Class2();
        }
    }
}
