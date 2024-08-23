#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Thu Aug 22 09:11:12 2024

@author: sharminalina
"""
# Leet code problem No. 12. Interger to Roman Converter
num = 2
roman =[]

while num > 0:
    if num > 1000:
        n2 = num // 1000
        num = num % 1000
        for i in range(n2):
            roman.append('M')
    elif num > 100:
        n2 = num // 100
        num = num % 100
            
        if n2 < 4:
            roman.append('C')
        elif n2 == 4:
            roman.append('CD')
        elif n2 == 5:
            roman.append('D')
        elif n2 == 6:
            roman.append('DC')
        elif n2 == 7:
            roman.append('DCC')
        elif n2 == 8:
            roman.append('DCCC')
        elif n2 == 9:
            roman.append('CM')
    elif num > 10:
        n2 = num // 10
        num = num % 10
            
        if n2 < 4:
            roman.append('X')
        elif n2 == 4:
            roman.append('XL')
        elif n2 == 5:
            roman.append('L')
        elif n2 == 6:
            roman.append('LX')
        elif n2 == 7:
            roman.append('LXX')
        elif n2 == 8:
            roman.append('LXXX')
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
        elif n2 == 6:
            roman.append('VI')
        elif n2 == 7:
            roman.append('VII')
        elif n2 == 8:
            roman.append('VIII')
        elif n2 == 9:
            roman.append('IX')
        else:
            break
            
    else:
        break
            
                
    
    
    
print("".join(roman))
        
        
