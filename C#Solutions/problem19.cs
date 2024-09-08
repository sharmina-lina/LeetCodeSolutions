using System;

namespace AllProblems
{
    

    public static class Problem19
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
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;

            ListNode fast = dummy;
            ListNode slow = dummy;

            // Move the fast pointer n+1 steps forward
            for (int i = 0; i <= n; i++)
            {
                fast = fast.next;
            }

            // Move both fast and slow until fast reaches the end
            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }

            // Remove the nth node
            slow.next = slow.next.next;

            return dummy.next;
        }

        // This method solves the problem and is called from Program.cs
        public static void Solve()
        {
            Console.WriteLine("Enter the values for the linked list (comma-separated): ");
            string[] input = Console.ReadLine().Split(',');

            // Convert the input string to integers and create the linked list
            ListNode head = CreateLinkedList(input);

            // Print the original list
            Console.WriteLine("Original List:");
            PrintList(head);

            // Read input for n (nth node from the end)
            Console.Write("\nEnter the value of n (nth node from the end to be removed): ");
            int n = int.Parse(Console.ReadLine());

            // Call RemoveNthFromEnd to remove the node
            ListNode result = RemoveNthFromEnd(head, n);

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

        

       
        
            
        

        
