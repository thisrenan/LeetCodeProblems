// See https://aka.ms/new-console-template for more information
using LeetCode;

Console.WriteLine("Hello, World! This is a project to practice and solve LeetCodeProblems");
Console.WriteLine("\nLets start with 1. Two Sum: ");

int[] result = new int[2];
result = TwoSum.TwoSumSolve([3, 2, 4], 6);
if (result[0] == 1 & result[1] == 2)
{
    Console.WriteLine("TwoSum validated [3, 2, 4], 6 == [1,2]");
}
else
{
    Console.WriteLine("TwoSum failed");
}

result = TwoSum.TwoSumSolve([1, 2, 7, 8], 3);
if (result[0] == 0 & result[1] == 1)
{
    Console.WriteLine("TwoSum validated [1, 2, 7, 8], 3 == [0,1]");
}
else
{
    Console.WriteLine("TwoSum failed");
}

Console.WriteLine("\nLets go for 2. Add Two Numbers: ");

int[] l1 = new int[] { 2, 4, 3 };
int[] l2 = new int[] { 5, 6, 4 };

AddTwoNumbers.ListNode listNode1 = AddTwoNumbers.LinkNodeValues(l1);
AddTwoNumbers.ListNode listNode2 = AddTwoNumbers.LinkNodeValues(l2);
AddTwoNumbers.ListNode listNode3 = AddTwoNumbers.AddTwoNumbersSolve(listNode1, listNode2);
int[] lResult = AddTwoNumbers.ListNodeValues(listNode3);


if (lResult[0] == 7 & lResult[1] == 0 & lResult[2] == 8)
{
    Console.WriteLine("AddTwoNumbers validated [2, 4, 3], [5,6,4] == [7, 0, 8]");
}
else
{
    Console.WriteLine("AddTwoNumbers failed");
}

int[] l3 = new int[] { 0 };
int[] l4 = new int[] { 0 };

AddTwoNumbers.ListNode listNode4 = AddTwoNumbers.LinkNodeValues(l3);
AddTwoNumbers.ListNode listNode5 = AddTwoNumbers.LinkNodeValues(l4);
AddTwoNumbers.ListNode listNode6 = AddTwoNumbers.AddTwoNumbersSolve(listNode4, listNode5);
lResult = AddTwoNumbers.ListNodeValues(listNode6);

if (lResult[0] == 0)
{
    Console.WriteLine("AddTwoNumbers validated [0], [0] == [0]");
}
else
{
    Console.WriteLine("AddTwoNumbers failed");
}

int[] l5 = new int[] { 9, 9, 9, 9, 9, 9, 9 };
int[] l6 = new int[] { 9, 9, 9, 9 };

AddTwoNumbers.ListNode listNode7 = AddTwoNumbers.LinkNodeValues(l5);
AddTwoNumbers.ListNode listNode8 = AddTwoNumbers.LinkNodeValues(l6);
AddTwoNumbers.ListNode listNode9 = AddTwoNumbers.AddTwoNumbersSolve(listNode7, listNode8);
lResult = AddTwoNumbers.ListNodeValues(listNode9);

if (lResult[0] == 8 & lResult[1] == 9 & lResult[2] == 9 & lResult[3] == 9 & lResult[4] == 0 & lResult[5] == 0 & lResult[6] == 0 & lResult[7] == 1)
{
    Console.WriteLine("AddTwoNumbers validated [9, 9, 9, 9, 9, 9, 9], [9, 9, 9, 9] == [8,9,9,9,0,0,0,1]");
}
else
{
    Console.WriteLine("AddTwoNumbers failed");
}