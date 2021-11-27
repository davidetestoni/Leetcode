namespace Leetcode;

public static class Problem53
{
    public static int MaxSubArray(int[] nums)
    {
        var sum = 0;
        var maxSum = int.MinValue;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                if (sum == 0)
                {
                    if (nums[i] > maxSum)
                    {
                        maxSum = nums[i];
                    }

                    continue;
                }

                sum += nums[i];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }

                if (sum < 0)
                {
                    sum = 0;
                }

                continue;
            }

            sum += nums[i];

            if (sum > maxSum)
            {
                maxSum = sum;
            }
        }

        return maxSum;
    }
}
