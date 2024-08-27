using System;

namespace AllProblems
{
    public static class Problem5
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 5");
            Console.WriteLine("Enter a string to find the largest palindrome substring:");
            string s = Console.ReadLine();
            string result = LongestPalindrome(s);
            Console.WriteLine("Longest Palindromic Substring: " + result);
        }

        public static string getPalindrome(string s, int low, int high)
        {
            while (low >= 0 && high < s.Length && s[low] == s[high])
            {
                low--;
                high++;
            }
            return s.Substring(low + 1, high - low - 1); // Correct slicing syntax for C#
        }

        public static string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            int maxLength = 1;
            string maxStr = s[0].ToString();  // Start with the first character as the longest palindrome

            for (int i = 1; i < s.Length; i++)
            {
                // Check for odd length palindromes
                string odd = getPalindrome(s, i - 1, i + 1);
                if (maxLength < odd.Length)
                {
                    maxLength = odd.Length;
                    maxStr = odd;
                }

                // Check for even length palindromes
                string even = getPalindrome(s, i - 1, i);
                if (maxLength < even.Length)
                {
                    maxLength = even.Length;
                    maxStr = even;
                }
            }

            return maxStr;
        }
    }
}
