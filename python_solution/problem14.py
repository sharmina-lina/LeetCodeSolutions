#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Wed Sep  4 14:09:31 2024

@author: sharminalina
"""

class Problem14:
    def longestCommonPrefix(self, strs: list[str])-> str:
        if not strs:
            return ""
        else:
            newStr = sorted(strs)
            firstStr = newStr[0]
            lastStr = newStr[-1]
            i = 0
            while(i < len(firstStr) and i < len(lastStr) and firstStr[i]==lastStr[i]):
                i +=1
            return firstStr[:i]

        


def main():
    
    # Read Integer array of height for calculating the area with most water
    
    print("Solution to Problem 14:Longest Common Prefix");
    
    inputString = input("Enter the list of strings (comma-separated): ")
    # Convert input string to a list of integers
    strs = [s.strip() for s in inputString.split(',')]
            
   # Find out the longest common prefix with the given array of strings
    solution_prob14 = Problem14()
    prefix = solution_prob14.longestCommonPrefix(strs)

    # Print the result
    print(f"The longest common pprefix is : {prefix}")

if __name__ == "__main__":
    main()