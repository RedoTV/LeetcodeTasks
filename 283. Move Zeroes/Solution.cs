/*

Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

*/

public class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int zeroCount = 0;
        for (int i = 0; i < nums.Length - zeroCount; i++)
        {
            if (nums[i] == 0)
            {
                for (int j = i; j < nums.Length - zeroCount - 1; j++)
                {
                    nums[j] = nums[j + 1];
                }
                nums[nums.Length - zeroCount - 1] = 0;
                zeroCount++;
                i--;
            }
        }
    }
}