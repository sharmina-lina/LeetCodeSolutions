#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Wed Aug 21 16:35:54 2024

@author: sharminalina
"""

height = [1,8,6,2,5,4,8,3,7]
n = len(height)
left = 0
right = n -1

maxarea = 0

while left < right:
    currentarea = min(height[left],height[right])*(right-left)
    maxarea = max(maxarea,currentarea)
    
    if(height[left] < height[right]):
        left +=1
    else:
        right -= 1
        
print(maxarea)