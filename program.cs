using System;

class Car
{
    public string model;
    public string color;
    public int price;

    public void PrintCarInformation()
    {
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Price: " + price);
    }
}

class Ferrari : Car
{
    public int speed;

    public void PrintSpeed()
    {
        Console.WriteLine("Speed: " + speed);
    }
}

class Maruti : Ferrari
{
    public float mileage;

    public void PrintMileage()
    {
        Console.WriteLine("Mileage: " + mileage);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Maruti myCar = new Maruti();

        myCar.model = "Alto";
        myCar.color = "White";
        myCar.price = 200000;
        myCar.mileage = 22.5f;
        myCar.speed = 100;

        myCar.PrintCarInformation();
        myCar.PrintMileage();
        myCar.PrintSpeed();

        Console.ReadLine();
    }
}
