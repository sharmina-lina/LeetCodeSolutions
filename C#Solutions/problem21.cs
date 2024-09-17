using System;

namespace AllProblems
{
    

    public static class Problem21
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
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;
            
            while(list1 != null && list2 != null){
                if(list1.val < list2.val){
                    current.next = list1;
                    list1 = list1.next;
                }
                else {
                    current.next = list2;
                    list2 = list2.next;
                }
                current = current.next;
            }
            // If one of the lists is not empty, attach the remainder of that list
             if (list1 != null)
            {
                current.next = list1;
            }
            else if (list2 != null)
            {
                current.next = list2;
            }
            return dummy.next;

            
        }

        // This method solves the problem and is called from Program.cs
        public static void Solve()
        {
            Console.WriteLine("Enter the values for the 1st linked list (comma-separated): ");
            string[] input1 = Console.ReadLine().Split(',');

            // Convert the input string to integers and create the linked list
            ListNode list1 = CreateLinkedList(input1);

            Console.WriteLine("Enter the values for the 2nd linked list (comma-separated): ");
            string[] input2 = Console.ReadLine().Split(',');

            // Convert the input string to integers and create the linked list
            ListNode list2 = CreateLinkedList(input2);
            
            // Print the original list
            Console.WriteLine("Original List:");
            PrintList(list1);
            PrintList(list2);

            // Call RemoveNthFromEnd to remove the node
            ListNode result = MergeTwoLists(list1, list2);

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

        

       
        
            
        

        
