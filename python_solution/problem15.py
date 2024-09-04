#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Wed Sep  4 14:23:37 2024

@author: sharminalina
"""

#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Aug 23 20:21:31 2024

@author: sharminalina
"""

class Problem15:
    def threeSum(self, nums: list[int])-> list[list[int]]:
        n = len(nums)
        result = set()

        if n < 3:
            print( "No Triplet")
        else:
            new_nums = sorted(nums)
            for i in range(n-2):
                low = i+1
                high = n-1
                while(low < high):
                    sum = new_nums[i] + new_nums[low] + new_nums[high]
                    if sum == 0:
                        result.add(tuple(sorted([new_nums[i],new_nums[low],new_nums[high]])))
                        low += 1
                        high -= 1
                    elif sum > 0:
                        high -= 1
                    elif sum < 0:
                        low +=1
            return result

def main():
    # Problem 15: 3 Sum
    nums_input = input("Enter the list of integers (comma-separated): ")
    # Convert input string to a list of integers
    nums = list(map(int, nums_input.split(',')))
    
    solution_prob15 = Problem15()
    result = solution_prob15.threeSum(nums)
    
    # Print the list of int whose sum is 0
    print(f"List of Numbers: {result}")

if __name__ == "__main__":
    main()
