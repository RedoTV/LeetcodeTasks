/*

Given an array of integers nums sorted in non-decreasing order, find the starting and ending position of a given target value.

If target is not found in the array, return [-1, -1].

You must write an algorithm with O(log n) runtime complexity.

*/

public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int[] range = [-1, -1];
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == target && range[0] == -1)
                range[0] = i;
            if (nums[i] == target)
                range[1] = i;
        }

        return range;
    }
}