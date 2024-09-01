using System;

namespace AllProblems
{
    public static class Problem8
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 8");
            
            Console.WriteLine("Enter a string to convert into intiger:");
            string s = Console.ReadLine();
            int result = convertStringtoIntiger(s);
            
            Console.WriteLine("Number converted from string: " + result);
            
        }

        

        public static int convertStringtoIntiger(string s)
        {
            int i = 0;
            int n = s.Length;
            int result = 0;
            int sign = 1;
            while(i < n && s[i] == ' '){
                i++;
            }
            if(i < n  && (s[i]== '-'||s[i]== '+')){
                sign = s[i] == '-'? -1: 1;
                i++;
            }
            if(i < n  && (s[i]== '-'||s[i]== '+')){
                return 0;
            }
            while(i< n && char.IsDigit(s[i]) ){
                int digit = s[i] -'0';
                if (result > (int.MaxValue - digit) / 10)
                {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }
                result = result*10 + digit;
                i++;
            }
        
            return result*sign;
            
        }

        
    }
}
