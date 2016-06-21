using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Meal
    {      
        public void cookMeal(Order order)
        {
            Console.WriteLine("The meal {0} has been cooked.", order.name);

        }
    }
}
