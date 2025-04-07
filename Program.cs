// See https://aka.ms/new-console-template for more information
using LeetCode;

Console.WriteLine("Hello, World! This is a project to practice and solve LeetCodeProblems");

int[] result = new int[2];
result = TwoSum.TwoSumSolve([3, 2, 4], 6);
if (result[0] == 1 & result[1] == 2) {
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
