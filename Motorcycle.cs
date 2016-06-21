using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string make, string model, int price, bool sold) : base(make, model, price, sold)
        {
            
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Motorbike details: \n{0} \n{1} \n{2} \nNumber of vehicles currently in stock: {3} \n",
                make, model, price, VehiclesInStock);
        }
    }
}
