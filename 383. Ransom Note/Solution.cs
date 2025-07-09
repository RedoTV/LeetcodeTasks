/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed by using the letters from magazine and false otherwise.

Each letter in magazine can only be used once in ransomNote.
*/

public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var magazineSb = new StringBuilder(magazine);
        for (int i = 0; i < ransomNote.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < magazineSb.Length; j++)
            {
                if (ransomNote[i] == magazineSb[j])
                {
                    magazineSb.Remove(j, 1);
                    found = true;
                    break;
                }
            }

            if (found == false)
                return found;
        }

        return true;
    }
}