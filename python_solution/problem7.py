#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Wed Aug 28 21:07:55 2024

@author: sharminalina
"""

# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
class Problem7:
    def reverseInteger(self, x: int)-> int:
        INT_MAX = 2**31 - 1
        
        reverseNumber = 0
        isNegative = False
        if(x < 0):
            isNegative = True
            x = -x
        while(x > 0):
            lastDigit = x%10
            if reverseNumber > (INT_MAX - lastDigit) // 10:
                return 0
            reverseNumber = reverseNumber*10 + lastDigit
            x = x//10
        if(isNegative):
            reverseNumber = -reverseNumber
        return reverseNumber

def main():
    # Read input from the console
   
    x= int(input("Input a Number to reverse digits: "))

    # Create an instance of Solution and find the length of the longest substring
    solution_prob7 = Problem7()
    result = solution_prob7.reverseInteger(x)

    # Print the result
    print(f"Reverse Digits of Number {x} is : {result}")

if __name__ == "__main__":
    main()
