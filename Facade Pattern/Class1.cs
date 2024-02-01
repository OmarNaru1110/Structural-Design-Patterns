using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    internal class Class1
    {
        public Class3 class3{ get; set; }
        public Class1(Class3 _class3)
        {
            class3 = _class3;
        }
        public void someClass2Method(string str)
        {
            class3.class2.someMethod(str);
        }
    }
}
