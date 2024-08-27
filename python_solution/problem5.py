#!/usr/bin/env python3
# -*- coding: utf-8 -*-

"""
Created on Tue Aug 27 17:01:20 2024

@author: sharminalina
"""
class Problem5:
    def getPalindrome(self,s, low, high):
        while low >= 0 and high < len(s) and s[low] == s[high]:
            low -= 1
            high += 1
        return s[low+1:high]
    
    def LongestPalindrome(self, s: str) -> str:
        if len(s) == 0:
            return ""
        
        max_length = 1
        max_str = s[0]  # Start with the first character as the longest palindrome

        
        
        for i in range(1, len(s)):
            odd = self.getPalindrome(s, i-1, i+1)
            if max_length < len(odd):
                max_length = len(odd)
                max_str = odd

            even = self.getPalindrome(s, i-1, i)
            if max_length < len(even):
                max_length = len(even)
                max_str = even
        return max_str

def main():
    # Read input from the console
    s = input("Enter a string: ")

    # Create an instance of Solution and find the length of the longest substring
    solution_prob5 = Problem5()
    result = solution_prob5.LongestPalindrome(s)

    # Print the result
    print(f"Longest Palindrome: {result}")

if __name__ == "__main__":
    main()
 
    


    


   


