#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Wed Sep 18 10:12:43 2024

@author: sharminalina
"""



class Problem22:
    def GenerateParenthesis(self, n: int)->list:
        result = []
        self.generate(result,'',0,0,n)
        return result
    def generate(self, result: list, current: str, opening_pos: int, closing_pos: int, max_pos: int)-> None:
        if(len(current) == max_pos*2):
            result.append(current)
            return
        if(opening_pos < max_pos):
            self.generate(result, current+'(', opening_pos+1,closing_pos,max_pos)
        if(closing_pos < opening_pos):
            self.generate(result, current+')', opening_pos,closing_pos+1,max_pos)
            
        
        
    
def main():
    # Problem 22: Give a number to generate the valid possible parenthesis
    n = int(input("Enter a number to generate the valid parenthesis: "))
    
    
    # Genrate parenthesis
    
    solution_prob22 = Problem22()
    result = solution_prob22.GenerateParenthesis(n)
    
    # Print the list of int whose sum is 0
    print(f"The list of possible parenthesis are : {result}")

if __name__ == "__main__":
    main()