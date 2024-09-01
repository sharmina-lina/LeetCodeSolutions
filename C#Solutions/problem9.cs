using System;

namespace AllProblems
{
    public static class Problem9
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 9");
            
            Console.WriteLine("Enter a Number to check Palindrome:");
            int x = int.Parse(Console.ReadLine());
            bool result = IsPalindrome(x);
            
            Console.WriteLine("Palindrome Number: " + result);
            
        }

        

        public static bool IsPalindrome(int x)
        {
            int num = x;
            int palindromeNumber = 0;
            if(num < 0){
                num = -num;
            }
            while (num > 0){
                int digit = num % 10;
                palindromeNumber = palindromeNumber * 10 + digit;
                num = num /10;
            }
            if(palindromeNumber == x){
                return true;
            }
             else {
                return false;
            }
        }

        
    }
}
