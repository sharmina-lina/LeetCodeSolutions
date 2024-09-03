using System;
using System.Xml.XPath;

namespace AllProblems
{
    public static class Problem10
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 10: Regular Expression Matching");
            
            Console.WriteLine("Enter a string to Match with the pattern:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter a pattern for Match with the string:");
            string p = Console.ReadLine();

            bool result = matchingStringWithPattern(s,p);
            
            Console.WriteLine("Number converted from string: " + result);
            
        }

        

        public static bool matchingStringWithPattern(string s, string p)
        {   
            if(s == p){
                return true;
            
            }
            else {
                return false;
            }
        
            
        }

        
    }
}
