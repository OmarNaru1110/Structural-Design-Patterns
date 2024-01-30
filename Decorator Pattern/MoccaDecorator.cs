using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class MoccaDecorator : ToppingDecorator
    {
        Beauverage _b;
        public MoccaDecorator(Beauverage b)
        {
            _b = b;
        }
        public override int cost()
        {
            return _b.cost() + 1; //cost of the beauverage + cost of the mocca
        }
    }
}
