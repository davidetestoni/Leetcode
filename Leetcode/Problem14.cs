namespace Leetcode;

public static class Problem14
{
    public static string LongestCommonPrefix(string[] strs)
    {
        var prefix = "";

        for (int i = 0; ; i++)
        {
            var first = strs[0];

            if (first.Length < i + 1)
            {
                return prefix;
            }

            var currChar = first[i];

            for (int j = 1; j < strs.Length; j++)
            {
                var str = strs[j];

                if (str.Length < i + 1 || str[i] != currChar)
                {
                    return prefix;
                }
            }

            prefix += currChar;
        }
    }
}
