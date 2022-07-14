using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {

        //TODO

        //Create a seperate class file called Car
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise property

        public Car() //Probably didn't need but I put it back in anyway
        {

        }

        public Car(int year, string make, string model, string honkNoise, string engineNoise, bool canDrive)
        {
            Year = year;
            Make = make;
            Model = model;
            HonkNoise = honkNoise;
            EngineNoise = engineNoise;
            CanDrive = canDrive;

        }

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string HonkNoise { get; set; }
        public string EngineNoise { get; set; }
        public bool CanDrive { get; set; }



        public void DisplayCarInfo() //Didn't ask for this. Just created for practice
        {
            Console.WriteLine("Car Information:");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Driveable: {CanDrive}");
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine($"{Make}'s say {HonkNoise}...");
        }

        public void MakeEngineNoise()
        {
            Console.WriteLine($"...and go {EngineNoise}.");
        }


































    }
}
