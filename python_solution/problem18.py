#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Aug 26 18:57:13 2024

@author: sharminalina
"""

nums = [-3,-1,0,2,4,5]
target = 2
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
    print(result)
            
                


