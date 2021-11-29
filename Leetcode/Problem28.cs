namespace Leetcode;

public static class Problem28
{
    // Note: return 0 for empty needle, -1 for not found
    public static int StrStr(string haystack, string needle)
    {
        // Obvious solution:
        // return haystack.IndexOf(needle);

        if (needle.Length == 0)
        {
            return 0;
        }

        for (int i = 0; i < haystack.Length; i++)
        {
            var matching = 0;

            for (int j = 0; j < needle.Length; j++)
            {
                if (i + j < haystack.Length && haystack[i + j] == needle[j])
                {
                    matching++;
                }
            }

            if (matching == needle.Length)
            {
                return i;
            }
        }

        return -1;
    }
}
