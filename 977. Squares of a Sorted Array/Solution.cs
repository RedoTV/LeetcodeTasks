/*
Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.
*/

public class Solution
{
    public int[] SortedSquares(int[] nums)
    {
        return nums.Select(n => n * n)
            .OrderBy(x => x)
            .ToArray();
    }
}