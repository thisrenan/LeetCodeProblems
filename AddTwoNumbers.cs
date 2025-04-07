using System.Xml.Linq;

namespace LeetCode
{
    public static class AddTwoNumbers
    {
        /*
            You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

            You may assume the two numbers do not contain any leading zero, except the number 0 itself.
 
            Example 1:
            Input: l1 = [2,4,3], l2 = [5,6,4]
            Output: [7,0,8]
            Explanation: 342 + 465 = 807.

            Example 2:
            Input: l1 = [0], l2 = [0]
            Output: [0]

            Example 3:
            Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
            Output: [8,9,9,9,0,0,0,1]
        */

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

        public static ListNode AddTwoNumbersSolve(ListNode l1, ListNode l2)
        {
            ListNode temp = new ListNode((l1.val + l2.val) % 10);
            int carry = (l1.val + l2.val) / 10;

            if (l1.next != null || l2.next != null || carry > 0)
            {
                l1.next = l1.next ?? new ListNode(0);
                l2.next = l2.next ?? new ListNode(0);
                l1.next.val = l1.next.val + carry;
                temp.next = AddTwoNumbersSolve(l1.next, l2.next);
            }
            return temp;
        }

        public static int ListNodeLenght(ListNode l1)
        {
            ListNode node = l1;
            int i = 0;
            while (node.next != null)
            {
                i++;
                node = node.next;
            }

            return i+1;
        }

        public static int[] ListNodeValues(ListNode l1)
        {
            ListNode node = l1;
            int i = ListNodeLenght(l1);
            int[] l1Values = new int[i];

            for (int j = 0; j < i; j++)
            {
                l1Values[j] = node.val;
                node = node.next;
            }

            return l1Values;
        }

        public static ListNode LinkNodeValues(int[] values)
        {
            if (values.Length > 0)
            {
                if (values.Length == 1)
                {
                    return new ListNode(values[0], null);
                }
                else
                {
                    ListNode first = new ListNode(values[0], null);

                    for (int i = 1; i < values.Length; i++)
                    {
                        ListNode next = new ListNode(values[i], first);
                        first = next;
                    }

                    return first;
                }
            }

            return null;
        }
    }
}