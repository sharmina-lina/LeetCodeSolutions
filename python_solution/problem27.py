#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Sat Sep 21 19:34:34 2024

@author: sharminalina
"""

class Problem27:
    def RemoveElement(self, nums: list[int], val: int) -> int:
        
        if not nums:
            return 0

        # Pointer for the position of unique elements
        new_pos = 0
        
        
        for i in range(len(nums)):
           if nums[i] != val:
               nums[new_pos] = nums[i]
               new_pos += 1
                

        # Return the number of unique elements
        return new_pos
    
def main():
    print("Solution of Leet problem No.27: remove all occurrences of given number")
    
    ## Taking input array from the console
    nums_input = input("Enter a array with comma ',' saperated number like 1,2,3: ")
    nums = list(map(int, nums_input.split(',')))
    val = int(input("Enter a value to remove from the list: "))
    solution_prob27 = Problem27()
    result = solution_prob27.RemoveElement(nums, val)
    
    # Printing the length of the array after removing the elements
    print(f"Length after removing the elements: {result}")
    # Printing the array after remove the given item
    print(f"Array after removing the elements: {nums[:result]}")

    
if __name__ == "__main__":
    main()