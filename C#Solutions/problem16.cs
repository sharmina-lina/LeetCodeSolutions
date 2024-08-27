using System;

namespace AllProblems
{
    public static class Problem16
    {
        public static void Solve()
        {
            int[] nums = [-1,2,1,-4];
            int target = 1;
            int result = CloseestSum(nums, target);
            Console.WriteLine("Closest sum: " + result);
        }

        public static int CloseestSum(int[] nums, int target)
        {
            int n = nums.Length;
            int closestSum = int.MaxValue;
            for(int i = 0; i < n-2; i++){
                int low = i+1;
                int high = n-1;

                while(low < high){
                    int currSum = nums[i]+nums[low] + nums[high];
                    if(Math.Abs(currSum -target) < Math.Abs(closestSum - target)){
                        closestSum = currSum;
                    }
                    if(currSum > target) low ++;
                    else high --;

                }

            }
            return closestSum;


            
        }

        
    }
}
