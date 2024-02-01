using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    internal class ItemDiscount : IDiscount
    {
        public double GetDiscountValue(DateTime curDate, string itemId = null)
        {
            //complex logic, or database access
            return 0.10;
        }
    }
}
