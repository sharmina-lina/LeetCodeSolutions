using System;

namespace AllProblems
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

    public static class Problem2
    {
        public static void Solve()
        {
            Console.WriteLine("Enter the digits for the first number (e.g., 2 4 3 for 342):");
            ListNode l1 = CreateListFromInput(Console.ReadLine());

            Console.WriteLine("Enter the digits for the second number (e.g., 5 6 4 for 465):");
            ListNode l2 = CreateListFromInput(Console.ReadLine());

            ListNode result = AddTwoNumbers(l1, l2);

            Console.WriteLine("Result:");
            PrintListNode(result);
        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int l1Num = ConvertListNodeToNumber(l1);
            int l2Num = ConvertListNodeToNumber(l2);

            int sum = l1Num + l2Num;

            ListNode result = ConvertNumberToListNode(sum);
            return result;
        }

        static int ConvertListNodeToNumber(ListNode node)
        {
            int number = 0;
            int multiplier = 1;

            while (node != null)
            {
                number += node.val * multiplier;
                multiplier *= 10;
                node = node.next;
            }

            return number;
        }

        static ListNode ConvertNumberToListNode(int number)
        {
            if (number == 0) return new ListNode(0);

            ListNode head = null;
            ListNode current = null;

            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;

                ListNode newNode = new ListNode(digit);

                if (head == null)
                {
                    head = newNode;
                    current = head;
                }
                else
                {
                    current.next = newNode;
                    current = current.next;
                }
            }

            return head;
        }

        static ListNode CreateListFromInput(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return null;

            string[] parts = input.Split(' ');
            ListNode head = null;
            ListNode current = null;

            foreach (string part in parts)
            {
                int digit = int.Parse(part);

                ListNode newNode = new ListNode(digit);

                if (head == null)
                {
                    head = newNode;
                    current = head;
                }
                else
                {
                    current.next = newNode;
                    current = current.next;
                }
            }

            return head;
        }

        static void PrintListNode(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val);
                if (node.next != null) Console.Write(" -> ");
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}
