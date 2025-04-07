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
            int[] l1Values = new int[ListNodeLenght(l1)];
            int[] l2Values = new int[ListNodeLenght(l2)];

            l1Values = ListNodeValues(l1);
            l2Values = ListNodeValues(l2);

            int l1Final = l1Values.Select((t, i) => t * Convert.ToInt32(Math.Pow(10, l1Values.Length - i - 1))).Sum();
            int l2Final = l2Values.Select((t, i) => t * Convert.ToInt32(Math.Pow(10, l2Values.Length - i - 1))).Sum();

            int l3 = l1Final + l2Final;

            int[] l3Values = l3.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();

            return LinkNodeValues(l3Values);
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