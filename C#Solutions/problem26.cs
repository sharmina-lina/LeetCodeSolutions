using System;
using System.Collections.Generic;

namespace AllProblems
{
    public static class Problem26
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 26");
            // Read the array from console
            Console.WriteLine("Enter a array of integers (comma-separated):");
            int[] nums = ReadIntArrayFromConsole();


            // Find the length of array after remove the duplicate item of sorted array 
            int result = RemoveDuplicates(nums);
            Console.WriteLine($"Length of sorted arrays after remove duplicate : {result}");
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

        public static int RemoveDuplicates(int[] nums) {

            int unique_pos = 0;
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++){
                if(nums[unique_pos] != nums[i]){
                    unique_pos ++;
                    nums[unique_pos] = nums[i];
                }

            }
        
            
            return unique_pos + 1;
        }
    }
}