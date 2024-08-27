#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Aug 26 18:57:13 2024

@author: sharminalina
"""

nums = [-1,0,1,2,-1,-4]
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
    print(result)
            
                


