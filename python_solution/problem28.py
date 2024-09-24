#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Sep 24 20:46:48 2024

@author: sharminalina
"""

class Problem28:
    def strStr(self, haystack: str, needle: str) -> int:
        if needle == "":
            return 0
        
        j = len(needle)

        for i in range(len(haystack)):
            if haystack[i:i+j] == needle:
                return i
        
        return -1
            
                
    
def main():
    print("Solution of Leet problem No.28: Find the index of first occurance in a string")
    
    ## Taking input first string from the console
    haystack = input("Enter the first string: ")
    needle = input("Enter the first string: ")
    
    solution_prob28 = Problem28()
    result = solution_prob28.strStr(haystack, needle)
    
    # Printing the index of first occurance in the given string
    print(f"Length after removing the elements: {result}")
    

    
if __name__ == "__main__":
    main()