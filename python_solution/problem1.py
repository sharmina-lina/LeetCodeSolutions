#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Aug 23 20:21:31 2024

@author: sharminalina
"""

from typing import List

def twoSum(nums: List[int], target: int) -> List[int]:
    for i in range(len(nums)):
        for j in range(i + 1, len(nums)):
            if nums[i] + nums[j] == target:
                return [i, j]
    return []

def main():
    # Prompt user to enter the list of numbers
    nums_input = input("Enter the list of integers (comma-separated): ")
    # Convert input string to a list of integers
    nums = list(map(int, nums_input.split(',')))
    
    # Prompt user to enter the target integer
    target = int(input("Enter the target integer: "))

    # Find the indices of the two numbers that add up to the target
    result = twoSum(nums, target)
    
    if result:
        print(f"Indices of the two numbers that add up to the target: {result}")
    else:
        print("No two numbers add up to the target.")

if __name__ == "__main__":
    main()
