#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Sep  3 19:44:31 2024

@author: sharminalina
"""

class Problem12:
    def integerToRoman(self, num: int)-> str:
        roman =[]

        while num > 0:
            if num >= 1000:
                n2 = num // 1000
                num = num % 1000
                for i in range(n2):
                    roman.append('M')
            elif num >= 100:
                n2 = num // 100
                num = num % 100
                if n2 < 4:
                    for i in range(n2):
                        roman.append('C')
                elif n2 == 4:
                    roman.append('CD')
                elif n2 == 5:
                    roman.append('D')
                elif n2 > 5 and n2 < 9:
                    roman.append('D')
                    for i in range(5,n2):
                        roman.append('C')
                elif n2 == 9:
                    roman.append('CM')
            elif num >= 10:
                n2 = num // 10
                num = num % 10
                if n2 < 4:
                    for i in range(n2):
                        roman.append('X')
                elif n2 == 4:
                    roman.append('XL')
                elif n2 == 5:
                    roman.append('L')
                elif n2 > 5 and n2 < 9:
                    roman.append('L')
                    for i in range(5,n2):
                        roman.append('X')
                
                elif n2 == 9:
                    roman.append('XC')
            elif num > 0:
                n2 = num
                num = 0
            
                if n2 < 4:
                    for i in range(n2):
                        roman.append('I')
                elif n2 == 4:
                    roman.append('IV')
                elif n2 == 5:
                    roman.append('V')
                elif n2 > 5 and n2 < 9:
                    roman.append('V')
                    for i in range(5,n2):
                        roman.append('I')
                   
                
                elif n2 == 9:
                    roman.append('IX')
                else:
                    break
            
            else:
                break
            
                
        return ("".join(roman)) 

def main():
    
    # Read Integer array of height for calculating the area with most water
    
    print("Solution to Problem 12:Integer to Roman");
            
   
    
    num = int(input("Enter the number convert to Roman : "))
   

    # Find the maximum area of container with most water
    solution_prob12 = Problem12()
    romanNumber = solution_prob12.integerToRoman(num)

    # Print the result
    print(f"The Roman number of given integer : {romanNumber}")

if __name__ == "__main__":
    main()