using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Adaptee : IAdaptee
    {
        public void SpeceficRequest(double y, int x)
        {
            Console.WriteLine($"{y} first\n {x} second");
        }
    }
}
