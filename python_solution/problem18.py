#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Aug 26 18:57:13 2024

@author: sharminalina
"""


class Problem18:
    def fourSum(self, nums: list[int], target: int)-> list[list[int]]:
        n = len(nums)
        result = set()

        if n < 4:
            print( "No Triplet")
        else:
            new_nums = sorted(nums)
            for i in range(n-3):
                for j in range(i+1, n-2):
                    low = j+1
                    high = n-1
                    while(low < high):
                        sum = new_nums[i] + new_nums[j] + new_nums[low] + new_nums[high]
                        if sum == target:
                            result.add(tuple(sorted([new_nums[i],new_nums[j],new_nums[low],new_nums[high]])))
                            low += 1
                            high -= 1
                        elif sum > target:
                            high -= 1
                        elif sum < target:
                            low +=1
            return result
            
def main():
    # Problem 18: 4 Sum
    nums_input = input("Enter the list of integers (comma-separated): ")
    # Convert input string to a list of integers
    nums = list(map(int, nums_input.split(',')))
    
    ## Input target to compare with the sum
    target = int(input("Enter a number as target: "))
    
    solution_prob18 = Problem18()
    result = solution_prob18.fourSum(nums,target)
    
    # Print the list of int whose sum is 0
    print(f"List of Numbers: {result}")

if __name__ == "__main__":
    main()                


