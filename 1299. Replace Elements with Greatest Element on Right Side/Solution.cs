/*
Given an array arr, replace every element in that array with the greatest element 
among the elements to its right, and replace the last element with -1.

After doing so, return the array.
*/

public class Solution
{
    public int[] ReplaceElements(int[] arr)
    {
        int max = -1;

        for (int i = arr.Length - 1; i >= 0; i--)
        {
            int temp = arr[i];
            arr[i] = max;

            if (temp > max)
                max = temp;
        }

        return arr;
    }
}