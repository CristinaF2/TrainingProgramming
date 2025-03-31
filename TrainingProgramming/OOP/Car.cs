using System.Runtime.InteropServices;

namespace TrainingProgramming.OOP
{
    public class Car
    {
        string engine;
        string color;
        int numberOfDoors;
        double cilinders;
        string gearboxType;

        public Car(string engine, string color, int numberOfDoors, double cilinders)
        {
            this.engine=engine;
            this.color=color;
            this.numberOfDoors=numberOfDoors;
            this.cilinders=cilinders;
        }

         public Car(string engine, string color, int numberOfDoors, double cilinders, string gearboxType)
        {
            this.engine=engine;
            this.color=color;
            this.numberOfDoors=numberOfDoors;
            this.cilinders=cilinders;
            this.gearboxType=gearboxType;
        }
        public void DisplayeData()
        {
           
            Console.WriteLine($"The engine of the car is: {engine}");
            Console.WriteLine($"The color of the car is: {color}");
            Console.WriteLine($"The number of doors of the car is: {numberOfDoors}");
            Console.WriteLine($"The cilinder of the car is: {cilinders}");

            if (gearboxType is not null)
            {
                Console.WriteLine($"The gearbox of the car is: {gearboxType}");
            }
        }

    }
}
