#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Tue Sep 17 21:18:09 2024

@author: sharminalina
"""


from typing import Optional

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem21:
    
    def mergeTwoLists(self, list1: Optional[ListNode], list2: Optional[ListNode]) -> Optional[ListNode]:
        dummy = ListNode(0)
        current = dummy
        
        while list1 is not None and list2 is not None:
            if list1.val < list2.val:
                current.next = list1
                list1 = list1.next
            else:
                current.next = list2
                list2 = list2.next
            
            current = current.next
        
        if list1 is not None:
            current.next = list1
        elif list2 is not None:
            current.next = list2
        
        

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
    print("Problem No. 21 : Marge two linked list and then sort them")
    
    # Input List Node1
    list1_input = input("Enter the list1 of integers (comma-separated): ")
    # Convert input string to a list of integers
    list1_num = list(map(int, list1_input.split(',')))
    
    # Input List Node 2
    list2_input = input("Enter the list2 of integers (comma-separated): ")
    # Convert input string to a list of integers
    list2_num = list(map(int, list2_input.split(',')))
    
    
    solution_prob21 = Problem21()
    
    list1 = solution_prob21.CreateLinkedList(list1_num)
    list2 = solution_prob21.CreateLinkedList(list2_num)
   
    solution_prob21.printList(list1)
    solution_prob21.printList(list2)
    
    
    
    
    result = solution_prob21.mergeTwoLists(list1, list2);

    # Print the modified list
    print("Marge and sorted List:");
    solution_prob21.printList(result)

if __name__ == "__main__":
    main()