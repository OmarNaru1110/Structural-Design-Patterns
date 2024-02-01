using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    internal interface IDiscount
    {
        double GetDiscountValue(DateTime curDate, string itemId = null);
    }
}
