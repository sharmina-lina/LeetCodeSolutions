// See https://aka.ms/new-console-template for more information
using System;

namespace AllProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select a problem to solve:");
            Console.WriteLine("1: Two Sum");
            Console.WriteLine("2: Add two numbers");
            Console.WriteLine("3: Longest substring without reapeting numbers");
            Console.WriteLine("4: Medians of two sorted array");
            Console.WriteLine("5: Longest Pelindromic substring");
            Console.WriteLine("6: Zigzag Conversion");
            Console.WriteLine("7: Reverse Integer");
            Console.WriteLine("8: String to Integer");
            Console.WriteLine("9: Pelindrome Number");
            Console.WriteLine("10: Regular Expression matching");
            Console.WriteLine("11: Container with most water");
            Console.WriteLine("12: Integer to Roman");
            Console.WriteLine("13: Roman to Integer");
            Console.WriteLine("14: Longest Common prefix");
            Console.WriteLine("15: 3 Sum");
            Console.WriteLine("16: 3 Sum Closets");
            Console.WriteLine("17: Letter combination of a phone number");
            Console.WriteLine("18: 4Sum");
            Console.WriteLine("19: Remove Nth Node from the end of list");
            Console.WriteLine("20: Valid Parenthesis");
            Console.WriteLine("21: Marge two sorted list");
            Console.WriteLine("22: Generate Parenthesis");
            Console.WriteLine("23: Marge K sorted List");
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
                case "21":
                    Problem21.Solve();
                    break;
                case "22":
                    Problem22.Solve();
                    break;
                case "23":
                    Problem23.Solve();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}

