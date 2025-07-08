public class Solution
{
    public int[] PlusOne(int[] digits)
    {
        bool needMoreMemory = true;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            digits[i] += 1;

            if (digits[i] == 10)
            {
                digits[i] = 0;
                continue;
            }
            else
            {
                needMoreMemory = false;
                break;
            }
        }

        if (needMoreMemory == true)
        {
            int[] moreDigits = new int[digits.Length + 1];
            moreDigits[0] = 1;
            for (int i = 1; i < moreDigits.Length; i++)
            {
                moreDigits[i] = digits[i - 1];
            }

            return moreDigits;
        }

        return digits;
    }
}