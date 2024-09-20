using System;

namespace AllProblems
{
    

    public static class Problem24
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
        public static ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode current = dummy;
            
            while(current.next != null && current.next.next != null){
                ListNode first = current.next;
                ListNode second = current.next.next;

                first.next = second.next;
                second.next = first;
                current.next = second;

                current = first;
            }
                
                
            
            // If one of the lists is not empty, attach the remainder of that list
             
            return dummy.next;

            
        }

        // This method solves the problem and is called from Program.cs
        public static void Solve()
        {
            Console.WriteLine("Enter the values for the 1st linked list (comma-separated): ");
            string[] input1 = Console.ReadLine().Split(',');

            // Convert the input string to integers and create the linked list
            ListNode head = CreateLinkedList(input1);


            // Call RemoveNthFromEnd to remove the node
            ListNode result = SwapPairs(head);

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

        

       
        
            
        

        
