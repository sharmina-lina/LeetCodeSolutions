#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Wed Sep 18 12:24:37 2024

@author: sharminalina
"""

from typing import Optional
import heapq

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem23:
    
    def mergeKsortedLists(self, linked_lists: list[Optional[ListNode]]) -> Optional[ListNode]:
        min_heap = []
    
        # Initialize the heap with the head of each linked list
        for i, lst in enumerate(linked_lists):
            if lst:
                heapq.heappush(min_heap, (lst.val, i, lst))  # Push (value, index, node)
    
        dummy = ListNode()  # Dummy node to simplify handling the head of the result list
        current = dummy
    
        while min_heap:
        # Extract the node with the smallest value
            val, i, node = heapq.heappop(min_heap)
        
        # Attach it to the result linked list
            current.next = ListNode(val)
            current = current.next
            
        # If the extracted node has a next node, push it to the heap
            if node.next:
                heapq.heappush(min_heap, (node.next.val, i, node.next))
    
        return dummy.next
        
    
    
    def list_to_linked_list(self,lst):
        dummy = ListNode()  # A dummy node to simplify handling the head
        current = dummy
        for val in lst:
            current.next = ListNode(val)
            current = current.next
        return dummy.next

    def printList(self, head: ListNode) -> None:
        current = head
        while current is not None:
            print(current.val, end=" ")
            current = current.next
        print()
    
    def input_linked_lists(self):
        input_str = input("Enter a list of lists (e.g. [[1,4,5],[1,3,4],[2,6]]): ")
        lists = eval(input_str)  # Convert string input to a list of lists
        linked_lists = [self.list_to_linked_list(lst) for lst in lists]
        return linked_lists

            



def main():
    print("Problem No. 23 : Marge K sorted List")
    
    
    solution_prob23 = Problem23()
    linked_lists = solution_prob23.input_linked_lists()
   
    result = solution_prob23.mergeKsortedLists(linked_lists);

    # Print the modified list
    print("Marge K sorted List:");
    solution_prob23.printList(result)

if __name__ == "__main__":
    main()