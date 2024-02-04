using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern.OrderSystem
{
    internal class Box : IOrder
    {
        public List<IOrder> Orders;
        public Box()
        {
            Orders = new List<IOrder>();
        }
        public int GetPrice()
        {
            int price = 0;
            foreach (IOrder o in Orders)
                price += o.GetPrice();
            return price;
        }
    }
}
