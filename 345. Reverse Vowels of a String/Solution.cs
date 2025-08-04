/*
Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.


Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"
*/

public class Solution
{
    public string ReverseVowels(string s)
    {
        List<int> charsInd = new List<int>();
        string vowels = "aeiouAEIOU";
        for (int i = 0; i < s.Length; i++)
        {
            if (vowels.Contains(s[i]))
                charsInd.Add(i);
        }

        var charsIndCount = charsInd.Count();
        var sc = s.ToCharArray();
        for (int i = 0; i < charsIndCount / 2; i++)
        {
            var temp = sc[charsInd[charsIndCount - 1 - i]];
            sc[charsInd[charsIndCount - 1 - i]] = sc[charsInd[i]];
            sc[charsInd[i]] = temp;
        }

        return new string(sc);
    }
}