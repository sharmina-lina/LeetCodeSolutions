using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace AllProblems
{
    public static class Problem23
    {
        public class ListNode : IComparable<ListNode>
        {
            public int val;
            public ListNode next;

            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }

            public int CompareTo(ListNode other)
            {
                return this.val.CompareTo(other.val);
            }

            public override string ToString()
            {
                return val + (next != null ? " -> " + next.ToString() : " -> null");
            }
        }

        // Method to merge k sorted linked lists
        public static ListNode MergeKSortedLists(List<ListNode> lists)
        {
            if (lists == null || lists.Count == 0)
                return null;

            // Use a priority queue to handle duplicates
            var priorityQueue = new PriorityQueue<ListNode, int>();

            // Add the head of each list to the priority queue
            foreach (var list in lists)
            {
                if (list != null)
                {
                    priorityQueue.Enqueue(list, list.val);
                }
            }

            ListNode dummy = new ListNode();
            ListNode current = dummy;

            // Extract nodes from the priority queue and build the merged list
            while (priorityQueue.Count > 0)
            {
                ListNode node = priorityQueue.Dequeue();
                current.next = new ListNode(node.val);
                current = current.next;

                if (node.next != null)
                {
                    priorityQueue.Enqueue(node.next, node.next.val);
                }
            }
            return dummy.next;
        }

        // This method solves the problem and is called from Program.cs
        public static void Solve()
        {
            List<ListNode> linkedLists = InputLinkedLists();
            
            // Merge k sorted lists
            ListNode result = MergeKSortedLists(linkedLists);

            // Print the merged list
            Console.WriteLine("Merged List:");
            PrintList(result);
        }

        public static ListNode CreateLinkedList(List<int> input)
        {
            if (input.Count == 0)
                return null;

            ListNode head = new ListNode(input[0]);
            ListNode current = head;

            for (int i = 1; i < input.Count; i++)
            {
                current.next = new ListNode(input[i]);
                current = current.next;
            }

            return head;
        }

        // Helper method to print the list
        public static void PrintList(ListNode head)
        {
            ListNode current = head;
            while (current != null)
            {
                Console.Write(current.val + " ");
                current = current.next;
            }
            Console.WriteLine();
        }

        public static List<ListNode> InputLinkedLists()
        {
            Console.WriteLine("Enter a list of lists (e.g. [[1,4,5],[1,3,4],[2,6]]): ");
            string inputStr = Console.ReadLine();
            // Convert input string to list of lists using JSON deserialization
            List<List<int>> lists = JsonConvert.DeserializeObject<List<List<int>>>(inputStr);

            // Convert each list of integers into a linked list
            List<ListNode> linkedLists = new List<ListNode>();
            foreach (var lst in lists)
            {
                linkedLists.Add(CreateLinkedList(lst));
            }

            return linkedLists;
        }
    }
}
