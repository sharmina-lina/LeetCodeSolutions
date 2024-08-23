using System;
using System.Collections.Generic;

namespace AllProblems
{
    public static class Problem1
    {
        public static void Solve()
        {
            // Prompting the user for input
            Console.WriteLine("Enter the numbers separated by spaces (e.g., 2 7 11 15):");
            string input = Console.ReadLine();

            // Converting the input string to an integer array
            int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);

            Console.WriteLine("Enter the target number:");
            int target = int.Parse(Console.ReadLine());

            // Calling the TwoSum method with user inputs
            int[] result = TwoSum(nums, target);

            // Displaying the result
            if (result != null)
            {
                Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            }
            else
            {
                Console.WriteLine("No solution found.");
            }
        }

        // The TwoSum method should be outside of the Solve method
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }
    }
}
