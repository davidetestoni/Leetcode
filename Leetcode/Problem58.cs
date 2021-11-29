namespace Leetcode;

public static class Problem58
{
    public static int LengthOfLastWord(string s)
    {
        // Framework solution
        // ------------------
        // s = s.TrimEnd(' ');
        // var index = s.LastIndexOf(' ');
        // return index == -1 ? s.Length : s.Length - (index + 1);

        // Manual solution
        var wordLength = 0;
        var newWord = true;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == ' ')
            {
                newWord = true;
            }
            else
            {
                if (newWord)
                {
                    wordLength = 1;
                    newWord = false;
                }
                else
                {
                    wordLength++;
                }
            }
        }

        return wordLength;
    }
}
