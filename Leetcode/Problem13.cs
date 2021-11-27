namespace Leetcode;

public static class Problem13
{
    public static int RomanToInt(string s)
    {
        var value = 0;
        var reduceNext = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == 'I')
            {
                if (PeekNext(s, i, new char[] { 'V', 'X' }))
                {
                    reduceNext = true;
                }
                else
                {
                    value += 1;
                }
            }
            else if (s[i] == 'V')
            {
                if (reduceNext)
                {
                    value += 4;
                    reduceNext = false;
                }
                else
                {
                    value += 5;
                }
            }
            else if (s[i] == 'X')
            {
                if (reduceNext)
                {
                    value += 9;
                    reduceNext = false;
                }
                else if (PeekNext(s, i, new char[] { 'L', 'C' }))
                {
                    reduceNext = true;
                }
                else
                {
                    value += 10;
                }
            }
            else if (s[i] == 'L')
            {
                if (reduceNext)
                {
                    value += 40;
                    reduceNext = false;
                }
                else
                {
                    value += 50;
                }
            }
            else if (s[i] == 'C')
            {
                if (reduceNext)
                {
                    value += 90;
                    reduceNext = false;
                }
                else if (PeekNext(s, i, new char[] { 'D', 'M' }))
                {
                    reduceNext = true;
                }
                else
                {
                    value += 100;
                }
            }
            else if (s[i] == 'D')
            {
                if (reduceNext)
                {
                    value += 400;
                    reduceNext = false;
                }
                else
                {
                    value += 500;
                }
            }
            else if (s[i] == 'M')
            {
                if (reduceNext)
                {
                    value += 900;
                    reduceNext = false;
                }
                else
                {
                    value += 1000;
                }
            }
        }

        return value;
    }

    private static bool PeekNext(string s, int i, char[] chars)
    {
        if (s.Length > i + 1)
        {
            var c = s[i + 1];

            foreach (var cc in chars)
            {
                if (cc == c)
                {
                    return true;
                }
            }
        }

        return false;
    }
}
