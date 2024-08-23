#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Aug 23 20:36:12 2024

@author: sharminalina
"""
class Problem3:
    def lengthOfLongestSubstring(self, s: str) -> int:
        substrings = set()
        start = 0
        max_length = 0

        for i in range(len(s)):
            while s[i] in substrings:
                substrings.remove(s[start])
                start += 1
            substrings.add(s[i])
            max_length = max(max_length, i - start + 1)

        return max_length

def main():
    # Read input from the console
    s = input("Enter a string: ")

    # Create an instance of Solution and find the length of the longest substring
    solution_prob3 = Problem3()
    result = solution_prob3.lengthOfLongestSubstring(s)

    # Print the result
    print(f"Length of the longest substring without repeating characters: {result}")

if __name__ == "__main__":
    main()
