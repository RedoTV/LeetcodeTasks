/*
Given an integer n, return true if it is a power of four. Otherwise, return false.

An integer n is a power of four, if there exists an integer x such that n == 4x.


Example 1:

Input: n = 16
Output: true
Example 2:

Input: n = 5
Output: false
Example 3:

Input: n = 1
Output: true
*/

public class Solution
{
    public bool IsPowerOfFour(int n)
    {
        if (n <= 0)
            return false;

        int twoCount = 0;
        while (n % 2 == 0)
        {
            twoCount++;
            n = n / 2;
        }

        return n == 1 && twoCount % 2 == 0;
    }
}