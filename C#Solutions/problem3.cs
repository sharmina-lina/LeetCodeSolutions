using System;
using System.Collections.Generic;

namespace AllProblems
{
    public static class Problem3
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 1");
            // Add the problem 1 logic here
            Console.WriteLine("Enter a string to find the length of the longest substring without repeating characters:");
            string s = Console.ReadLine();
            int result = LengthOfLongestSubstring(s);
            Console.WriteLine(result);
        }

        public static int LengthOfLongestSubstring(string s) {
            HashSet<char> substrings = new HashSet<char>();

            int start = 0;
            int max_length = 0;

            for (int i = 0; i < s.Length; i++){
                while(substrings.Contains(s[i])){
                    substrings.Remove(s[start]);
                    start++;
                }
                substrings.Add(s[i]);
                max_length = Math.Max(max_length, i - start +1);

            }
            return max_length;
        
        }
    }
}