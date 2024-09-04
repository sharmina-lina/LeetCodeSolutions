using System;
using System.Globalization;
using System.Xml.XPath;

namespace AllProblems
{
    public static class Problem18
    {
        public static void Solve()
        {
            Console.WriteLine("Solution to Problem 18: 4Sum");
            
            Console.WriteLine("Enter a list of numbers separated by space (e.g., 1 -1 2 -4 0 etc):");
        
            // Read the input from the console
            string input = Console.ReadLine();
        
            // Split the input string by commas to get individual numbers
            int[] nums = Array.ConvertAll(input.Split(' '), int.Parse);

            // Input a target number
            Console.WriteLine("Enter a number as target");
            int target = int.Parse(Console.ReadLine());

            // For example, finding the longest common prefix
            IList<IList<int>> result = fourSum(nums,target);
            foreach (var quardlet in result){
                
                Console.WriteLine($"[{string.Join(", ", quardlet)}]");
            }
            
            
        }

        

        public static IList<IList<int>> fourSum(int[] nums, int target)
        {   
            int n = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            if (n < 4){
                return result;
            }
            
             else{
                Array.Sort(nums);
                for(int i = 0; i < n-3; i++){
                    if(i > 0 && nums[i] == nums[i-1]){
                    continue;
                    }
                    for (int j = i+1; j < n-2; j++ ){
                        int low = j +1;
                        int high = n-1;
                        while(low < high){
                            int sum = nums[i] +nums[j] + nums[low] + nums[high];
                            if (sum == target){
                                result.Add(new List<int> { nums[i], nums[j],nums[low], nums[high] });
                                while (low < high && nums[low] == nums[low + 1]) low++;
                                while (low < high && nums[high] == nums[high - 1]) high--;

                                low ++;
                                high --;
                            }
                            if (sum < target){
                                low ++;

                            }
                            if (sum > target){
                                high --;
                            }

                        }
                    }

                }
            
            
                return result;

                    
            }    
        
            
        }

        
    }
}
