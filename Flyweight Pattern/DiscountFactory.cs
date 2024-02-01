using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    internal class DiscountFactory
    {
        IDiscount discount = null;

        public IDiscount GetDiscount(string type) 
        {
            switch (type)
            {
                case "date":
                    discount = new DateDiscount(); 
                    break;
                case "item":
                    discount = new ItemDiscount();
                    break;
            }
            return discount;
        }
    }
}
