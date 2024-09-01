#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Sun Sep  1 17:15:46 2024

@author: sharminalina
"""
import itertools
dict1 = {'1':'', '2': 'abc', '3': 'def', '4': 'ghi',
         '5': 'jkl', '6':'mno', '7': 'pqrs', '8': 'tuv', '9': 'wxyz'}

digits = input("Enter your digits: ")
arr_out = []
#arr_out.extend([dict1['2'][0], dict1['3'][0]])
print(''.join(arr_out))

if digits == "":
    print("[]")

else:
    groups = [dict1[digit] for digit in digits]
    
    for combination in itertools.product(*groups):
        arr_out.append(''.join(combination))
    

print(arr_out)
            
            
        
