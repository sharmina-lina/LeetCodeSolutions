using System;
using System.Collections.Generic;

namespace AllProblems
{
    public static class Problem4
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 4");
            // Read the first array
            Console.WriteLine("Enter the 1st array of integers (comma-separated):");
            int[] nums1 = ReadIntArrayFromConsole();

            // Read the second array
            Console.WriteLine("Enter the 2nd array of integers (comma-separated):");
            int[] nums2 = ReadIntArrayFromConsole();

            // Find the median of the combined sorted arrays
            double result = FindMedianSortedArrays(nums1, nums2);
            Console.WriteLine($"Median of the two sorted arrays: {result}");
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

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2) {

            double median;
            int l = nums1.Length + nums2.Length;
            var myList = new List<int>();
            myList.AddRange(nums1);
            myList.AddRange(nums2);
            int[] arr3 = myList.ToArray();
            Array.Sort(arr3);
            if (l%2 == 0)
            {
                median = (arr3[l/2] + arr3[l/2 -1])/2.0;
    
            }
            else
            {
                median = arr3[(l-1)/2];
            }
            return median;
        }
    }
}