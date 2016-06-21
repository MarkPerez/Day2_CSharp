using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            int carSales = Car.VehiclesInStock = 0;
            //int bikeMotorcycle.vehiclesSold = 0;

            Car car1 = new Car("Ford", "Fiesta", 5000, false);
            car1.DisplayDetails();
           
            Car car2 = new Car("Nissan", "Micra", 7500, false);
            car2.DisplayDetails();

            Car car3 = new Car("Mini", "Cooper", 8000, false);
            car3.DisplayDetails();

            car3.SellVehicle(true, 7000);

            Car car4 = new Car("Rolls Royce", "Silver Cloud", 35000, false);
            car4.DisplayDetails();

            Motorcycle motorcycle1 = new Motorcycle("BikeMake", "BikeModel", 5000, false);
            motorcycle1.DisplayDetails();
                      
            List<Car> carList = new List<Car>();

            carList.Add(car1);
            carList.Add(car2);
            carList.Add(car4);

            Car.CalcTotalPrice(carList);
        }
    }
}
