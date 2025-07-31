/*

Given a string columnTitle that represents the column title as appears in an Excel sheet, return its corresponding column number.

For example:

A -> 1
B -> 2
C -> 3
...
Z -> 26
AA -> 27
AB -> 28 
...

*/

public class Solution
{
    public int TitleToNumber(string columnTitle)
    {
        int sum = 0;
        for (int i = 0; i < columnTitle.Length; i++)
        {
            int charValue = columnTitle[i] - 'A' + 1;
            sum = sum * 26 + charValue;
        }

        return sum;
    }
}