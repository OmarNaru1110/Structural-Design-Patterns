using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Pattern
{
    public class Adapter : ITarget
    {
        IAdaptee _adaptee;
        public Adapter(IAdaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void request(int x, double y)
        {
            _adaptee.SpeceficRequest(y, x);
        }
    }
}
