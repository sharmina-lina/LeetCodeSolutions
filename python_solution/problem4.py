#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Aug 23 20:40:04 2024

@author: sharminalina
"""

from typing import List

class Problem4:
    def findMedianSortedArrays(self, nums1: List[int], nums2: List[int]) -> float:
        # Combine the two lists and sort the result
        combined = nums1 + nums2
        combined.sort()

        # Find the length of the combined list
        l = len(combined)

        # Calculate the median
        if l % 2 == 0:
            # Even length: average of the two middle elements
            median = (combined[l // 2 - 1] + combined[l // 2]) / 2
        else:
            # Odd length: middle element
            median = combined[l // 2]

        return median

def main():
    # Read input for the first array
    nums1_input = input("Enter the first sorted array of integers (comma-separated): ")
    nums1 = list(map(int, nums1_input.split(',')))
    
    # Read input for the second array
    nums2_input = input("Enter the second sorted array of integers (comma-separated): ")
    nums2 = list(map(int, nums2_input.split(',')))

    # Create an instance of Solution and find the median
    solution_prob4 = Problem4()
    median = solution_prob4.findMedianSortedArrays(nums1, nums2)

    # Print the result
    print(f"The median of the two sorted arrays is: {median}")

if __name__ == "__main__":
    main()
