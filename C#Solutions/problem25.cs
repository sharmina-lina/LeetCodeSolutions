using System;

namespace AllProblems
{
    

    public static class Problem25
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
            this.val = val;
            this.next = next;
            }
        }
        
        // This method removes the nth node from the end of the list
        public static ListNode ReverseKGroup(ListNode head, int k)
        {
            if (head == null || k == 1) 
                return head;

            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode current = dummy, prevGroupEnd = dummy, groupStart = null;
    
            // Calculate the length of the list
            int length = 0;
            while (current.next != null)
            {
                length++;
                current = current.next;
             }

            // Re-initialize current to start of the list
            current = dummy;
    
            while (length >= k)
            {
                groupStart = current.next;
                ListNode next = current.next;
                ListNode prev = null;

            // Reverse k nodes
                for (int i = 0; i < k; i++)
                {
                    ListNode temp = next.next;
                    next.next = prev;
                    prev = next;
                    next = temp;
                 }

            // Connect with the previous part and the next part of the list
            prevGroupEnd.next = prev;
            groupStart.next = next;

            // Move pointers
            prevGroupEnd = groupStart;
            current = prevGroupEnd;
            length -= k;
            }

            return dummy.next;
            
        }

        // This method solves the problem and is called from Program.cs
        public static void Solve()
        {
            Console.WriteLine("Enter the values for the 1st linked list (comma-separated): ");
            string[] input1 = Console.ReadLine().Split(',');

            // Convert the input string to integers and create the linked list
            ListNode head = CreateLinkedList(input1);

            Console.WriteLine("Enter the number to reverse in group ");
            int k = int.Parse(Console.ReadLine());


            // Call RemoveNthFromEnd to remove the node
            ListNode result = ReverseKGroup(head, k);

            // Print the modified list
            Console.WriteLine("\nModified List:");
            PrintList(result);
        }

        public static ListNode CreateLinkedList(string[] input)
        {
            if (input.Length == 0)
                return null;

            ListNode head = new ListNode(int.Parse(input[0]));
            ListNode current = head;

            for (int i = 1; i < input.Length; i++)
            {
                current.next = new ListNode(int.Parse(input[i]));
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
    }
}

        

       
        
            
        

        
