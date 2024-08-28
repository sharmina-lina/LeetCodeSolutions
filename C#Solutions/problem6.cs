using System;

namespace AllProblems
{
    public static class Problem6
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 6");
            Console.WriteLine("Enter a string to find the ZigZag string:");
            string s = Console.ReadLine();
            Console.WriteLine("Enter a Int number of rows:");
            int numRows = int.Parse(Console.ReadLine());
            string result = zigzagString(s,numRows);
            Console.WriteLine("Longest Palindromic Substring: " + result);
        }

        

        public static string zigzagString(string s, int numRows)
        {
            if (string.IsNullOrEmpty(s))
            {
                return "";
            }

            if(numRows == 1){
            return s;
            
        }
        int len = s.Length;
        string []arr = new string[numRows];
        int row = 0;
        bool down = true;
        for(int i = 0; i < len; i++){
            arr[row] += (s[i]);
    
            if (row == numRows-1){
                down = false;
            }
            else if(row == 0){
                down = true;
            }
            if(down){
                row++;
            }
            else{
                row--;
            }

        }
        string result = string.Join("", arr);
        return result;

        }
    }
}
