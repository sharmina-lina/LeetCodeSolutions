#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Sep 20 20:22:52 2024

@author: sharminalina
"""

from typing import Optional

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem25:
    
    def reverseKGroup(self, head: Optional[ListNode], k: int) -> Optional[ListNode]:
        if head == None or k == 1:
            return head

        dummy = ListNode(0)
        dummy.next = head
        current = dummy
        prevGroupEnd = dummy
        groupStart = None
    
        # Calculate the length of the list
        length = 0
        while current.next != None:
            length += 1
            current = current.next
    

        # Re-initialize current to start of the list
        current = dummy
    
        while length >= k:
    
            groupStart = current.next
            next = current.next;
            prev = None
        

            # Reverse k nodes
            for i in range(0,k):
                temp = next.next
                next.next = prev
                prev = next
                next = temp
        

            # Connect with the previous part and the next part of the list
            prevGroupEnd.next = prev;
            groupStart.next = next;

            # Move pointers
            prevGroupEnd = groupStart;
            current = prevGroupEnd;
            length -= k;
            
        
        

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
    print("Problem No. 25 : Reverse Node in K groups")
    
    # Input List Node1
    list1_input = input("Enter the list1 of integers (comma-separated): ")
    # Convert input string to a list of integers
    list1_num = list(map(int, list1_input.split(',')))
    
    
    solution_prob25 = Problem25()
    
    head = solution_prob25.CreateLinkedList(list1_num)
    
    # Input a number of group to reverse
    
    k = int(input("Enter a number for performing the reverse of that group: "))
    
    
    
    result = solution_prob25.reverseKGroup(head,k);

    # Print the modified list
    print("Reverse Node in K groups:");
    solution_prob25.printList(result)

if __name__ == "__main__":
    main()