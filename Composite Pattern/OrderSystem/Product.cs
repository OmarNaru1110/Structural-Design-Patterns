using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.OrderSystem
{
    internal class Product : IOrder
    {
        public Product(int price)
        {
            Price = price;
        }

        public int Price { get; }
        public int GetPrice() => Price;

    }
}
