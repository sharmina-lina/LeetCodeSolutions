// See https://aka.ms/new-console-template for more information
using System;

namespace AllProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a problem to solve:");
            Console.WriteLine("1: Problem 1");
            Console.WriteLine("2: Problem 2");
            Console.WriteLine("3: Problem 3");
            Console.WriteLine("4: Problem 4");
            Console.WriteLine("5: Problem 5");
            Console.WriteLine("6: Problem 6");
            Console.WriteLine("7: Problem 7");
            Console.WriteLine("16: Problem 16");
            Console.WriteLine("17: Problem 17");
            Console.Write("Enter your choice: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    Problem1.Solve();
                    break;
                case "2":
                    Problem2.Solve();
                    break;
                case "3":
                    Problem3.Solve();
                    break;
                case "4":
                    Problem4.Solve();
                    break;
                case "5":
                    Problem5.Solve();
                    break;
                case "6":
                    Problem6.Solve();
                    break;
                case "7":
                    Problem7.Solve();
                    break;
                case "16":
                    Problem16.Solve();
                    break;
                case "17":
                    Problem17.Solve();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

