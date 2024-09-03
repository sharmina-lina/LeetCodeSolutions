using System;



namespace AllProblems
{
    public static class Problem11
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 11:Container with most water");
            
            Console.WriteLine("Enter the numbers separated by spaces (e.g., 2 7 11 15):");
            string input = Console.ReadLine();

            // Converting the input string to an integer array
            int[] height = Array.ConvertAll(input.Split(' '), int.Parse);
            int maxArea = containerWithMostWater(height);
            
            Console.WriteLine("Maximum area of container with most water: " + maxArea);
            
        }

        

        public static int containerWithMostWater(int[] height)
        {
            int n = height.Length;   // Calculating length of height
            int left = 0;
            int right = n-1;

            int maxArea = 0 ; // Declare of maximum area
            while(left < right){
                int currentArea = Math.Min(height[left],height[right])*(right-left);
                maxArea = Math.Max(maxArea, currentArea);
                if(height[left] < height[right]){
                    left ++;
                }
                else {
                    right --;
                }
            }

        
            return maxArea;
            
        }

        
    }
}

