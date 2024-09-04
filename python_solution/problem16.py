#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Aug 27 20:34:09 2024

@author: sharminalina
"""
import sys
class Problem16:
    def threeSumClosest(self, nums: list[int],target)->int:
        closestSum = sys.maxsize
        n = len(nums)
                

        if n < 3:
            closestSum = 0
        else:
            new_nums = sorted(nums)
            for i in range(n-2):
                low = i+1
                high = n-1
                while(low < high):
                    current_sum = new_nums[i] + new_nums[low] + new_nums[high]
                    if (abs(closestSum -target) > abs(current_sum - target)):
                        closestSum = current_sum
                        low += 1
                        high -= 1
                    if current_sum > target:
                        high -= 1
                    elif current_sum < target:
                        low +=1
                    
        return closestSum


    
def main():
    # Problem 16: 3 Sum Closest
    nums_input = input("Enter the list of integers (comma-separated): ")
    # Convert input string to a list of integers
    nums = list(map(int, nums_input.split(',')))
    
    target = int(input("Enter a target number: "))
    
    solution_prob16 = Problem16()
    result = solution_prob16.threeSumClosest(nums,target)
    
    # Print the list of int whose sum is 0
    print(f"Closest sum of target : {result}")

if __name__ == "__main__":
    main()
