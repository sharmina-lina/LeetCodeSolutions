#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Aug 19 22:34:20 2024

@author: sharminalina
    
 """   
 
number = -121
x = number
INT_MAX = 2**31 - 1
INT_MIN = -2**31
reverseNumber = 0
isNegative = False
if(x < 0):
    isNegative = True
    x = -x
while(x > 0):
    lastDigit = x%10
    if reverseNumber > (INT_MAX - lastDigit) // 10:
        print(0)
    reverseNumber = reverseNumber*10 + lastDigit
    x = x//10
print(reverseNumber)
if(number == reverseNumber):
    print("True")
else:
    print("False")

