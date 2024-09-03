#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Sep  3 17:10:27 2024

@author: sharminalina
"""

class Problem11:
    def containerWithMostWater(self, height: list[int])-> int:
        n = len(height)  # Calculating length of height
        left, right = 0 , n-1
        

        maxArea = 0  # Declare of maximum area

        while(left < right):
            currentArea = min(height[left],height[right])*(right-left)
            maxArea = max(maxArea, currentArea)

            if(height[left]< height[right]):
                left += 1
            else:
                right -=1

        return maxArea

def main():
    
    # Read Integer array of height for calculating the area with most water
    
    print("Solution to Problem 11:Container with most water");
            
    print("Enter the numbers separated by spaces (e.g., 2 7 11 15):");
    
    nums_input = input("Enter the list of integers (comma-separated): ")
   
    height = list(map(int, nums_input.split(',')))

    # Find the maximum area of container with most water
    solution_prob11 = Problem11()
    maxArea = solution_prob11.containerWithMostWater(height)

    # Print the result
    print(f"The maximum area of container with most water is : {maxArea}")

if __name__ == "__main__":
    main()