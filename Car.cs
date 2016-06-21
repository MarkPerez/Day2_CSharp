using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class Car : Vehicle
    {
        public Car(string make, string model, int price, bool sold) : base(make, model, price, sold)
        {
            
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Car details: \n{0} \n{1} \n{2} \nNumber of vehicles currently in stock: {3} \n",
                make, model, price, VehiclesInStock);
        }         

        public static void CalcTotalPrice(List<Car> carList)
        {
            int totalPrice = 0;
            foreach (Car car in carList)
            {
                totalPrice += car.price;
            }
            Console.WriteLine("The total value of cars in stock is " + totalPrice);
        }
    }
}
