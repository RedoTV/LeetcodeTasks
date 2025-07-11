/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.
*/

public class Solution
{
    public int SingleNumber(int[] nums)
    {
        return nums.GroupBy(n => n)
            .ToDictionary(g => g.Key, g => g.Count())
            .Where(d => d.Value == 1)
            .Select(d => d.Key)
            .First();
    }
}