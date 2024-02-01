using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    internal class FlyweightDiscount
    {
        Dictionary<string, IDiscount> discount = new Dictionary<string, IDiscount>();
        DiscountFactory discountFactory = new DiscountFactory();
        public IDiscount GetDiscount(string type)
        {
            if(discount.ContainsKey(type))
                return discount[type];
            discount.Add(type, discountFactory.GetDiscount(type));
            return discount[type];
        }
    }
}
