#!/usr/bin/env python3
# -*- coding: utf-8 -*-
"""
Created on Fri Aug 23 20:24:32 2024

@author: sharminalina
"""

class ListNode:
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Problem1:
    def addTwoNumbers(self, l1: ListNode, l2: ListNode) -> ListNode:
        l1Num = self.convertListNodeToNumber(l1)
        l2Num = self.convertListNodeToNumber(l2)

        l12Num = l1Num + l2Num

        result = self.convertNumberToListNode(l12Num)

        return result

    def convertListNodeToNumber(self, node: ListNode) -> int:
        number = 0
        placeholder = 1

        while node is not None:
            number += node.val * placeholder
            placeholder *= 10
            node = node.next
        return number

    def convertNumberToListNode(self, number: int) -> ListNode:
        if number == 0:
            return ListNode(0)
        
        head = None
        current = None

        while number > 0:
            digit = number % 10
            number //= 10

            newNode = ListNode(digit)

            if head is None:
                head = newNode
                current = head
            else:
                current.next = newNode
                current = current.next
        
        return head

def printListNode(node: ListNode):
    values = []
    while node:
        values.append(str(node.val))
        node = node.next
    print(" -> ".join(values))

def main():
    # Input for l1
    l1_input = input("Enter the first linked list (comma-separated, least significant digit first): ")
    l1_values = list(map(int, l1_input.split(',')))
    l1 = None
    for value in reversed(l1_values):
        l1 = ListNode(value, l1)
    
    # Input for l2
    l2_input = input("Enter the second linked list (comma-separated, least significant digit first): ")
    l2_values = list(map(int, l2_input.split(',')))
    l2 = None
    for value in reversed(l2_values):
        l2 = ListNode(value, l2)

    # Compute the sum
    solution = Problem1()
    result = solution.addTwoNumbers(l1, l2)

    # Print the result
    print("Resulting linked list:")
    printListNode(result)

if __name__ == "__main__":
    main()
