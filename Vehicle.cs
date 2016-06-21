using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class Vehicle
    {
        public string make;
        public string model;
        public int price;
        public bool sold;
        public int salePrice;

        public static int VehiclesInStock;

        public Vehicle(string make, string model, int price, bool sold)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = sold;
            VehiclesInStock++;
        }

        public void AddVehicle(string make, string model, int price, bool sold)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = sold;
            VehiclesInStock++;
        }

        public void SellVehicle(bool sold, int salePrice)
        {
            this.sold = sold;
            this.salePrice = salePrice;
            VehiclesInStock--;
            Console.WriteLine("The {0} {1} has now been sold for {2} \n", make, model, salePrice);
        }
    }
}
