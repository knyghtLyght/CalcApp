using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro();
        }

        public static void Intro()
        {
            Console.WriteLine("Welcome to this roudamentry calculator");
            Console.WriteLine("Lets pick 2 numbers to play with.\nPlease enter the first number");
            double userNumberOne = Double.Parse(Console.ReadLine());
            Console.WriteLine("and now the second:");
            double userNumberTwo = Double.Parse(Console.ReadLine());
            Console.WriteLine("You can:\na) Add\nb) Multiply\nc) Divide\nd) Subtract");
            Console.WriteLine("please enter your choice");
            string userPath = Console.ReadLine();
            if (userPath == "a")
            {
                Console.WriteLine(Add(userNumberOne, userNumberTwo));
            }
            if (userPath == "b")
            {
                Console.WriteLine(Multiply(userNumberOne, userNumberTwo));
            }
            if (userPath == "c")
            {
                Console.WriteLine(Divide(userNumberOne, userNumberTwo));
            }
            if (userPath == "d")
            {
                Console.WriteLine(Subtract(userNumberOne, userNumberTwo));
            }
            Console.ReadLine();
        }

        public static double Add (double doubleOne, double doubletwo)
        {
            return doubleOne + doubletwo;
        }

        public static double Multiply(double doubleOne, double doubletwo)
        {
            return doubleOne * doubletwo;
        }

        public static double Divide(double doubleOne, double doubletwo)
        {
            return doubleOne / doubletwo;
        }

        public static double Subtract(double doubleOne, double doubletwo)
        {
            return doubleOne - doubletwo;
        }
    }
}
