//Method Overloading

namespace MethodOverloading
{
    class Program
    {
      //1st way to call
         void sum(int a , int b)
        {
            Console.WriteLine("Sum of two numbers is: " + (a + b));
        }

        void sum (float b, float a)
        {
            Console.WriteLine("Sum of two numbers is: " + (a + b));
        }

      //2nd way to call
         void sum(int a , int b)
        {
            Console.WriteLine("Sum of two numbers is: " + (a + b));
        }

        void sum (int a, int b, int c)
        {
            Console.WriteLine("Sum of two numbers is: " + (a + b + c));
        }

       //3rd way to call
         void sum(int a , float b)
        {
            Console.WriteLine("Sum of two numbers is: " + (a + b));
        }

        void sum (float a, int b)
        {
            Console.WriteLine("Sum of two numbers is: " + (a + b ));
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.sum(10, 20);
            p.sum(10.5f, 20.5f);
        }
    }
}


//Method Overriding

//Method Overhide
 namespace method_overriding
{

    class Dog
    {
        public void sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program : Dog
    {
        public new void sound()
        {
            Console.WriteLine("Dog Mau");
        }

        public static void Main(string[] args)
        {
            Dog d = new Dog();
            Program  p = new Program();
            p.sound();
            d.sound();
        }

    }

}

//Method Override
 namespace method_overriding
{

    class Dog
    {
        public virtual void sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program : Dog
    {
        public override void sound()
        {
            Console.WriteLine("Dog Mau");
        }

        public static void Main(string[] args)
        {
            Dog d = new Dog();
            Program  p = new dog();
            p.sound();
            d.sound();
        }

    }

}

//we can create use Parent class reference to create object of child class and call child class methood
