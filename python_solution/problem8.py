#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Aug 19 19:30:51 2024

@author: sharminalina
"""
class Problem8:
    def findIntegerfromString(self, s: str)-> str:
        i = 0
        n = len(s)
        sign = 1
        result = 0

        while i< n and s[i] == ' ':
            i +=1
            if (i < n and (s[i]== '-' or s[i]== '+')):
                sign = -1 if s[i]== '-' else 1
                i += 1
            if(i < n and (s[i] == '-' or  s[i] == '+')):
                result = 0
    
        while i < n and s[i].isdigit():
            digit = int(s[i])
            if result > (2**31 - 1 - digit) // 10:
                result=2**31 - 1 if sign == 1 else -2**31            

            result = result * 10 + digit
            i += 1

        return result*sign

def main():
    # Read input from the console
   
    x= input("Enter String to convert Into integer : ")

    # Create an instance of Solution and find the Integer from the String
    solution_prob8 = Problem8()
    result = solution_prob8.findIntegerfromString(x)

    # Print the result
    print(f"Integer Number of String {x} is : {result}")

if __name__ == "__main__":
    main()

