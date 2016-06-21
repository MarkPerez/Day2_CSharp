using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantManagement
{
    class Program
    {
        public static void Main(string[] args)
        {
            //add some meals data
            Order steak = new Order(steak);
            steak.addMeal("steak", 20.00M, 5.00M);
            Meal fajitas = new Meal();
            fajitas.addMeal("fajitas", 12.00M, 2.00M);
            Meal pumpkinRisotto = new Meal();
            pumpkinRisotto.addMeal("pumpkinRisotto", 10.00M, 1.00M);
            Order order1 = new Order();
            order1.takeOrder(steak);
            balance = Meal.cookMeal(steak, balance);

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            balance = Meal.cookMeal(pumpkinRisotto, balance);
            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);
        }
    }
}
