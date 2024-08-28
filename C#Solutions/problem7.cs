using System;

namespace AllProblems
{
    public static class Problem7
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 7");
            
            Console.WriteLine("Enter a Number to get the reverse digits:");
            int x = int.Parse(Console.ReadLine());
            int result = reverseInteger(x);
            Console.WriteLine("Reverse Digits of given Number : " + result);
        }

        

        public static int reverseInteger(int x)
        {
            int reverseNumber = 0;
             bool isNegative = false;
            if(x < 0){
                isNegative = true;
                x = -x;
            }
        

             while(x > 0){
                int lastDigit = x%10;
                if (reverseNumber > (Int32.MaxValue - lastDigit) / 10 ) 
                 {
                    reverseNumber = 0; // Overflow would occur, so return 0
                    break;
                }
                else{
                    reverseNumber = reverseNumber*10 + lastDigit;
                    x = x/10;

                }
            
            }
            if(isNegative){
                reverseNumber = -reverseNumber;
            }
            return reverseNumber;
        }
    }
}
