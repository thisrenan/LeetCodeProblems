namespace LeetCode
{
    public static class TwoSum
    {
        /*
           Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

           You may assume that each input would have exactly one solution, and you may not use the same element twice.

           You can return the answer in any order.

           Example 1:

           Input: nums = [2,7,11,15], target = 9
           Output: [0,1]
           Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

           Example 2:

           Input: nums = [3,2,4], target = 6
           Output: [1,2]

           Example 3:

           Input: nums = [3,3], target = 6
           Output: [0,1]
        */

        public static int[] TwoSumSolve(int[] nums, int target)
        {
            int[] result = new int[2];
            int[] compare = new int[2];
            bool firstAdd = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > target)
                {
                    continue;
                }
                if (!firstAdd)
                {
                    if (nums[i] < target)
                    {
                        result[0] = i;
                        compare[0] = nums[i];
                        firstAdd = true;
                    }
                }
                else
                {
                    if ((compare[0] + nums[i]) == target)
                    {
                        result[1] = i;
                        compare[1] = nums[i];
                        return result;
                    }
                    else
                    {
                        result[0] = i;
                        compare[0] = nums[i];
                        firstAdd = true;
                    }
                }
            }

            return result;
        }
    }
}

