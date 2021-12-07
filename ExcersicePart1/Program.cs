using System;

namespace ExcersicePart1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname, lname;
            int year, age;

            Console.WriteLine("Hi, enter your name!");
            fname = Console.ReadLine();
            Console.WriteLine("And your last name :)");
            lname = Console.ReadLine();
            Console.WriteLine($"Hello,{fname},{lname}");
            Console.WriteLine("Enter your age ");
            year = Convert.ToInt32(Console.ReadLine());
            int ConvertDate = DateTime.Now.Year;
            age = ConvertDate - year;

            if (age >= 10)
            {
                Console.WriteLine("Welcome to Instagram!");
            } else
            {
                Console.WriteLine("You are to young to have an Instagram account!");
            }

            
            
        }
      
    }
}
