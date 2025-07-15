
//Given an array nums of integers, return how many of them contain an even number of digits

public class Solution
{
    public int FindNumbers(int[] nums)
    {
        return nums.Select(n => n.ToString())
            .Where(s => s.Length % 2 == 0)
            .Count();
    }
}