using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Balance
    {
        private decimal cost;
        private decimal price;

        public decimal OrderBalance(Order order, decimal cost, decimal price)
        {
            return price - cost;
        }
    }
}
