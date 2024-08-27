#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Aug 27 20:34:09 2024

@author: sharminalina
"""
import sys


nums = [1, 1 ,1, 1]
target = 0
closestSum = sys.maxsize
n = len(nums)
        

if n < 3:
    print( "No Triplet")
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
            
    print(closestSum)