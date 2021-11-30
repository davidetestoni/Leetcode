namespace Leetcode;

public static class Problem69
{
    public static int MySqrt(int x)
    {
        // The square root for the largest integer value is 46340 so we start there and go down
        // Note: this is not optimal, the best approach would be to use binary search
        // to quickly move through numbers instead of going down by 1 for each iteration
        // (i.e. for sqrt(2) we need to go down from 46340 to 1, which means many iterations!)
        for (int i = 46340; i >= 0; i--)
        {
            if (i * i <= x)
            {
                return i;
            }
        }

        return 0;
    }
}
