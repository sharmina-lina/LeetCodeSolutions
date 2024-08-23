# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""

s = "PAYPALISHIRING";
n = 4;
length = len(s);
arr = [""] * n
row = 0;
down = True;
for i in range(length):
    arr[row] += (s[i])
    
    if row == n-1:
        down = False
    
    elif row == 0:
        down = True
    
    if down:
        row +=1
    
    else:
        row -=1
    


result = "".join(arr)
print(result)