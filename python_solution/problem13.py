#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Sep  3 20:04:24 2024

@author: sharminalina
"""
class Problem13:
    def romanToInt(self, romanNum: str)-> int:

        romanInt = {'I': 1, 'V': 5, 'X': 10, 'L': 50, 'C': 100, 'D': 500, 'M':1000 }
        num = 0
        i = 0
        while (i < len(romanNum)):
            if(i+1 < len(romanNum) and (romanInt[romanNum[i]] < romanInt[romanNum[i+1]])):
                num += (romanInt[romanNum[i+1]]- romanInt[romanNum[i]])
                i += 2
            else:
                num += romanInt[romanNum[i]]
                i += 1
        return num


def main():
    
    # Read Integer array of height for calculating the area with most water
    
    print("Solution to Problem 13:Roman to Integer");
            
   
    
    romanNum = input("Enter the Roman number convert to Integer : ")
   

    # Conver Roman Number to Integer
    solution_prob13 = Problem13()
    intNum = solution_prob13.romanToInt(romanNum)

    # Print the result
    print(f"The Integer of given Roman : {intNum}")

if __name__ == "__main__":
    main()