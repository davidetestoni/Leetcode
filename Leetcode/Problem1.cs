namespace Leetcode;

public static class Problem1
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();
        var index1 = -1;
        var index2 = -1;

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
                index1 = dict[target - nums[i]];
                index2 = i;
                break;
            }

            dict[nums[i]] = i;
        }

        return new int[] { index1, index2 };
    }
}
