#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Sat Sep 14 19:59:38 2024

@author: sharminalina
"""



class Problem20:
    def isValid(self, s: str)->bool:
        dict1 = {'(':')', '{': '}', '[': ']'}

        stack = []
        
        for c in s:
            if c in dict1.keys():
                stack.append(c)
            elif c in dict1.values():
                if not stack or dict1[stack[-1]] != c:
                    return False
                stack.pop()
        if not stack:
            return True
        else:
            return False

        
    

        

def main():
    # Problem 20: Give a string to validate
    s = input("Enter a string if bracket to validate: ")
    
    
    # Validation of the given string
    
    
    solution_prob20 = Problem20()
    result = solution_prob20.isValid(s)
    
    # Print the list of int whose sum is 0
    print(f"The given string is : {result}")

if __name__ == "__main__":
    main()