#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Sat Sep 21 18:25:23 2024

@author: sharminalina
"""

class Problem26:
    def removeDuplicates(self, nums: list[int]) -> int:
        if not nums:
            return 0

        # Pointer for the position of unique elements
        unique_pos = 0
        nums.sort()
        
        # Iterate over the list starting from the second element
        for i in range(1, len(nums)):
            # If the current element is not equal to the last unique element
            if nums[i] != nums[unique_pos]:
                unique_pos += 1  # Move the pointer for unique elements
                nums[unique_pos] = nums[i]  # Update the next position with the current unique element

        # Return the number of unique elements
        return unique_pos + 1
    
def main():
    print("Solution of Leet problem No.26: Remove duplicate from the sorted Array")
    
    ## Taking input array from the console
    nums_input = input("Enter a array with comma ',' saperated number like 1,2,3: ")
    nums = list(map(int, nums_input.split(',')))
    solution_prob26 = Problem26()
    result = solution_prob26.removeDuplicates(nums)
    
    # Printing the length of the array with unique elements
    print(f"Number of unique elements: {result}")
    # Printing the array after remove the duplicate item
    print(f"Array of unique elements: {nums[:result]}")

    
if __name__ == "__main__":
    main()