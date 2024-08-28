# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
class Problem6:
    def zigzagConversion(self, s: str, n: int)-> str:
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
        return result

def main():
    # Read input from the console
    s = input("Enter a string: ")
    n= int(input("Number of Rows: "))

    # Create an instance of Solution and find the length of the longest substring
    solution_prob6 = Problem6()
    result = solution_prob6.zigzagConversion(s,n)

    # Print the result
    print(f"ZigZag conversion of Given String {s} : {result}")

if __name__ == "__main__":
    main()
