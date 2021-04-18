using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Thanks for using my application! What is your name?");
            string name = Console.ReadLine();

           Console.WriteLine($"Hi {name}! Where would you like to travel? Mexico or Italy?");

            Console.ReadLine();
        }
    }
}
