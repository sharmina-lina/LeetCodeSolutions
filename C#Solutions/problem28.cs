using System;
using System.Collections.Generic;

namespace AllProblems
{
    public static class Problem28
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 28");
            // Read the array from console
            Console.WriteLine("Enter a string:");
            string haystack= Console.ReadLine();
            Console.WriteLine("Enter the 2nd string:");
            string needle= Console.ReadLine();

    
            // Find the Find the index of first occurance in a string
            int result = strStr(haystack,needle);
            Console.WriteLine($"the index of first occurance in a string: {result}");
        }

        

        public static int strStr(string haystack, string needle) {
            if(needle.Length == 0){
                return 0;
            }
            for (int i = 0; i < haystack.Length - needle.Length; i++){
                if (haystack.Substring(i, needle.Length) == needle){
                    return i;
                }
            
            }
            return -1;


            
        }
    }
}