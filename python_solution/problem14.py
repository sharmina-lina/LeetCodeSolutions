#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Mon Aug 26 09:25:50 2024

@author: sharminalina
"""

strs = ["flower","flow","flight"]

if strs == None or len(strs)== 0:
    print(" Empty String")

else:
    strNew = sorted(strs)
    n = len(strNew)
    lgstr = []
    i = 0
    while(strNew[0][i] == strNew[-1][i]):
        lgstr.append(strNew[0][i])
        i += 1

    print(''.join(lgstr))
    
    
        
        

            

    
