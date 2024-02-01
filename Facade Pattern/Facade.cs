using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    internal class Facade
    {
        public Class1 class1 { get; set; }
        public Facade()
        {
            class1=new Class1(new Class3());
        }
        public void GetClass2Method()
        {
            class1.someClass2Method("عم عيالي");
        }
    }
}
