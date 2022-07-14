using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bonus 2 - Instanciate the carlot class at the beginning of the program
            var onLot = new CarLot();

            //TODO
            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //Object initializing
            Car myCar = new Car(){ Year = 2002, Make = "Honda", Model = "Civic", HonkNoise = "eep eep", EngineNoise = "putt putt", CanDrive = true };
            //myCar.DisplayCarInfo();  //Redundant - made for practice
            myCar.MakeHonkNoise();
            myCar.MakeEngineNoise();
            Console.WriteLine();

           //Using Dot
            Car yourCar = new Car();
            yourCar.Year = 2011;
            yourCar.Make = "Chevy";
            yourCar.Model = "Malibu";
            yourCar.HonkNoise = "honk honk";
            yourCar.EngineNoise = "woosh";
            yourCar.CanDrive = true;
            //yourCar.DisplayCarInfo();  //Redundant - made for practice
            yourCar.MakeHonkNoise();
            yourCar.MakeEngineNoise();
            Console.WriteLine();

            //Method 3 - Don't know if this method has a specific name
            Car theirCar = new Car(2023, "Ford", "Focus", "tweet tweet", "*raspberry*", false);
            //theirCar.DisplayCarInfo();  //Redundant - made for practice
            theirCar.MakeHonkNoise();
            theirCar.MakeEngineNoise();
            Console.WriteLine();
            
            //*************BONUS X 2*************//
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            onLot.CarList.Add(myCar);
            onLot.CarList.Add(yourCar); //Bonus 2 - add cars to new list
            onLot.CarList.Add(theirCar);

            onLot.DisplayCarsList(); //Bonus 2 - Display the cars and basic info added to the new car list
        }
    }
}
