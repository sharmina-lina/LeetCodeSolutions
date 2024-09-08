#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Sun Sep  8 21:09:10 2024

@author: sharminalina
"""
from typing import Optional

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem19:
    
    def removeNthFromEnd(self, head: Optional[ListNode], n: int) -> Optional[ListNode]:
        dummy = ListNode(0);
        dummy.next = head;

        fast = dummy;
        slow = dummy;
        for i in range(n+1):
            fast = fast.next
        
        while fast is not None:
            fast = fast.next
            slow = slow.next

            
            
        slow.next = slow.next.next;

        return dummy.next;
        
    
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
    print("Problem No. 19 : Remove Nth node from End of list")
    
    nums_input = input("Enter the list of integers (comma-separated): ")
    # Convert input string to a list of integers
    nums = list(map(int, nums_input.split(',')))
    
    
    solution_prob19 = Problem19()
    
    head = solution_prob19.CreateLinkedList(nums)
    
    solution_prob19.printList(head)
    
    n = int(input("Enter the value of n (nth node from the end to be removed): "))
    
    # Call RemoveNthFromEnd to remove the node
    
    result = solution_prob19.removeNthFromEnd(head, n);

    # Print the modified list
    print("Modified List:");
    solution_prob19.printList(result)

if __name__ == "__main__":
    main()