using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Order
    {
        public string name;
        
        public void TakeOrder(string name)
        {
            this.name = name;
            Console.WriteLine("The meal {0} has been ordered.", name);
        }
    }
}
