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
            Console.WriteLine("8: Problem 8");
            Console.WriteLine("9: Problem 9");
            Console.WriteLine("10: Problem 10");
            Console.WriteLine("11: Problem 11");
            Console.WriteLine("12: Problem 12");
            Console.WriteLine("13: Problem 13");
            Console.WriteLine("14: Problem 14");
            Console.WriteLine("15: Problem 15");
            Console.WriteLine("16: Problem 16");
            Console.WriteLine("17: Problem 17");
            Console.WriteLine("18: Problem 18");
            Console.WriteLine("19: Problem 19");
            Console.WriteLine("20: Problem 20");
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
                case "8":
                    Problem8.Solve();
                    break;
                case "9":
                    Problem9.Solve();
                    break;
                case "10":
                    Problem10.Solve();
                    break;
                case "11":
                    Problem11.Solve();
                    break;
                case "12":
                    Problem12.Solve();
                    break;
                case "13":
                    Problem13.Solve();
                    break;
                case "14":
                    Problem14.Solve();
                    break;
                case "15":
                    Problem15.Solve();
                    break;
                case "16":
                    Problem16.Solve();
                    break;
                case "17":
                    Problem17.Solve();
                    break;
                case "18":
                    Problem18.Solve();
                    break;
                case "19":
                    Problem19.Solve();
                    break;
                case "20":
                    Problem20.Solve();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

