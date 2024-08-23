#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Aug 19 19:30:51 2024

@author: sharminalina
"""

print(" Leet code problem No. 8")
s= "-04n23"
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

print(result*sign)
    

