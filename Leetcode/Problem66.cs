namespace Leetcode;

public static class Problem66
{
    public static int[] PlusOne(int[] digits)
    {
        var allNines = true;

        foreach (var digit in digits)
        {
            if (digit != 9)
            {
                allNines = false;
                break;
            }
        }

        var outputLength = allNines ? digits.Length + 1 : digits.Length;
        var output = new int[outputLength];

        var carry = true;

        if (allNines)
        {
            output[0] = 1;

            for (int i = 1; i < output.Length; i++)
            {
                output[i] = 0;
            }
        }
        else
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (carry)
                {
                    if (digits[i] == 9)
                    {
                        // Set to 0 and keep carry
                        output[i] = 0;
                    }
                    else
                    {
                        output[i] = digits[i] + 1;
                        carry = false;
                    }
                }
                else
                {
                    output[i] = digits[i];
                }
            }
        }

        return output;
    }
}
