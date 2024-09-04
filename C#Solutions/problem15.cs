using System;
using System.Xml.XPath;

namespace AllProblems
{
    public static class Problem15
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 15: 3Sum");
            
            Console.WriteLine("Enter a list of numbers separated by space (e.g., 1 -1 2 -4 0 etc):");
        
            // Read the input from the console
            string input = Console.ReadLine();
        
            // Split the input string by commas to get individual numbers
            int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);

            // For example, finding the longest common prefix
            IList<IList<int>> result = ThreeSum(nums);
            foreach (var triplet in result){
                
                Console.WriteLine($"[{string.Join(", ", triplet)}]");
            }
            
            
        }

        

        public static IList<IList<int>> ThreeSum(int[] nums)
        {   
            int n = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            if (n < 3){
                return result;
            }
            
             else{
                Array.Sort(nums);
                for(int i = 0; i < n-2; i++){
                if(i > 0 && nums[i] == nums[i-1]){
                    continue;
                }
                int low = i +1;
                int high = n-1;
                while(low < high){
                    int sum = nums[i] + nums[low] + nums[high];
                    if (sum == 0){
                        result.Add(new List<int> { nums[i], nums[low], nums[high] });
                        while (low < high && nums[low] == nums[low + 1]) low++;
                        while (low < high && nums[high] == nums[high - 1]) high--;

                        low ++;
                        high --;
                    }
                    if (sum < 0){
                        low ++;

                    }
                    if (sum > 0){
                        high --;
                    }

                }
            }

        }
            
            
        return result;
        
            
        }

        
    }
}
