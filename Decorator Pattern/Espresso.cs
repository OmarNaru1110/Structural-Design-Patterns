using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern
{
    public class Espresso : Beauverage
    {
        public override int cost()
        {
            return 5;
        }
    }
}
