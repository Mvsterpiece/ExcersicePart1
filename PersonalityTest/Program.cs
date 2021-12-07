using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string userinput;
            Console.WriteLine("Hello, enter your favorite color");
            userinput = Console.ReadLine().ToLower();
            string template = $"You picked {userinput}"
            if (userinput == "red") ;
            {
                Console.WriteLine($"{template}, You are romantic!");
            }
            else if (userinput == "blue")
            {
                Console.WriteLine($"{template}, You are reliable!");
            }
            else if (userinput == "yellow")
            {
                Console.WriteLine($"{template}, You are reliable!");
            }
            else
            {

                Console.WriteLine($"{template}, You are a/an {userinput} unicorn!");

            }
    }
}
