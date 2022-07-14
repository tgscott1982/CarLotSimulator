using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    public class CarLot
    {
        //*************BONUS X 2*************//
        //Create a CarLot class
        //It should have at least one property: a List of cars

        public CarLot()
        {

        }

        public List<Car> CarList = new List<Car>();

        public void DisplayCarsList() //Bonus 2 - instance method to display basic info for all cars added to new car list
        {
            foreach (var car in CarList)
            {
                Console.WriteLine($"Year: {car.Year}, Make: {car.Make}, Model: {car.Model}");
            }
        }

    }
}
