using System;
using System.Collections.Generic;

namespace AllProblems
{
    public static class Problem27
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 27");
            // Read the array from console
            Console.WriteLine("Enter a array of integers (comma-separated):");
            int[] nums = ReadIntArrayFromConsole();

            // Read the integer value to remove the all occurance of that value
            Console.WriteLine("Enter an Integer number to remove from the array");
            int val = int.Parse(Console.ReadLine()); 


            // Find the length of array after remove the duplicate item of sorted array 
            int result = RemoveElement(nums,val);
            Console.WriteLine($"Length of array after remove the given array elements: {result}");
        }

        // Helper method to read an integer array from the console
        private static int[] ReadIntArrayFromConsole()
        {
            string input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                return new int[0];
            }

            return input.Split(',')
                        .Select(s => int.Parse(s.Trim()))
                        .ToArray();
        }

        public static int RemoveElement(int[] nums, int val) {

            int new_pos = 0;
            
            for (int i = 0; i < nums.Length; i++){
                if(nums[i] != val){
                    nums[new_pos]= nums[i];
                    new_pos ++;
                    
                }

            }
        
            
            return new_pos;
        }
    }
}