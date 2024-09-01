#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Aug 19 22:34:20 2024

@author: sharminalina
    
 """   
class Problem9:
    def isPalindrome(self, x: int)-> int:
        number = x
        INT_MAX = 2**31 - 1
        INT_MIN = -2**31
        palindromeNumber = 0
        isNegative = False
        if(number < 0):
            isNegative = True
            number = -number
        while(number > 0):
            lastDigit = number%10
            
            palindromeNumber = palindromeNumber*10 + lastDigit
            number = number//10
        
        if(x == palindromeNumber):
            return True
        else:
            return False

def main():
    # Read input from the console
   
    x= int(input("Enter Number to check palindrome : "))

    # Create an instance of Solution and find the number is Palindrome or not
    solution_prob9 = Problem9()
    result = solution_prob9.isPalindrome(x)

    # Print the result
    print(f"Is the number {x} Palindrome : {result}")

if __name__ == "__main__":
    main()
