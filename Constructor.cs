using System;

namespace CSharpConstructorsExamples
{
    // Example 1: A simple class with a parameterless constructor
    class ProgramExample
    {
        public ProgramExample()
        {
            Console.WriteLine("Hello, I am a constructor!");
        }
    }

    // Example 2: A parameterized constructor that initializes fields
    class Car
    {
        public string Model;
        public int Year;

        public Car(string model, int year)
        {
            Model = model;
            Year = year;
        }

        // Constructor overloading: same class/name, different parameter sequence
        public Car(int year, string model)
        {
            Model = model;
            Year = year;
        }

        public void PrintInformation()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Parameterless Constructor ===");
            ProgramExample example = new ProgramExample();

            Console.WriteLine();
            Console.WriteLine("=== Parameterized Constructor ===");
            Car myCar = new Car("Mustang", 1969);
            myCar.PrintInformation();

            Console.WriteLine();
            Console.WriteLine("=== Constructor Overloading ===");
            Car anotherCar = new Car(1967, "Impala");
            anotherCar.PrintInformation();

            Console.WriteLine();
            Console.WriteLine("=== Object Initialization (alternative) ===");
            Car carUsingObjectInitializer = new Car("Classic Car", 1965);
            carUsingObjectInitializer.Model = "Impala";
            carUsingObjectInitializer.Year = 1967;
            carUsingObjectInitializer.PrintInformation();
        }
    }
}
