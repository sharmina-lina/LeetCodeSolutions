#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Sun Sep  1 17:15:46 2024

@author: sharminalina
"""
import itertools
class Problem17:
    def letterCombinations(self, digits: str)->list[str]:
        dict1 = {'1':'', '2': 'abc', '3': 'def', '4': 'ghi',
         '5': 'jkl', '6':'mno', '7': 'pqrs', '8': 'tuv', '9': 'wxyz'}

        arr_out = []
        #arr_out.extend([dict1['2'][0], dict1['3'][0]])
        

        if digits == "":
            return "[]"

        else:
            groups = [dict1[digit] for digit in digits]
    
            for combination in itertools.product(*groups):
                arr_out.append(''.join(combination))
    

        return arr_out

def main():
    # Problem 17: Letter combination of a phone number
    digits = input("Enter the digits to convert to letter: ")
    
    
    # Convert input digits to letter
    
    
    solution_prob17 = Problem17()
    result = solution_prob17.letterCombinations(digits)
    
    # Print the list of int whose sum is 0
    print(f"possible combination of given digits : {result}")

if __name__ == "__main__":
    main()
            
            
        
