#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Sep 20 20:00:55 2024

@author: sharminalina
"""

from typing import Optional

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem24:
    
    def SwapPairs(self, head: Optional[ListNode]) -> Optional[ListNode]:
        dummy = ListNode(0)
        dummy.next = head
        current = dummy
        
        while current.next is not None and current.next.next is not None:
            first = current.next
            second = current.next.next
            
            first.next = second.next
            second.next = first
            current.next = second
            
            current = first
        
        

        return dummy.next
        
    
    def CreateLinkedList(self, nums: list[int])->ListNode:
        if len(nums) == 0:
            return None

        head = ListNode(nums[0])
        current = head
        for i in range(1,len(nums)):
            current.next = ListNode(nums[i])
            current = current.next
        return head
    
    def printList(self, head: ListNode) -> None:
        current = head
        while current is not None:
            print(current.val, end=" ")
            current = current.next
        print()

            



def main():
    print("Problem No. 24 : Swap node in pairs")
    
    # Input List Node1
    list1_input = input("Enter the list1 of integers (comma-separated): ")
    # Convert input string to a list of integers
    list1_num = list(map(int, list1_input.split(',')))
    
    
    
    
    solution_prob24 = Problem24()
    
    head = solution_prob24.CreateLinkedList(list1_num)
    
    
    
    result = solution_prob24.SwapPairs(head);

    # Print the modified list
    print("Swap node in pairs:");
    solution_prob24.printList(result)

if __name__ == "__main__":
    main()