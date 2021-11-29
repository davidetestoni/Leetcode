namespace Leetcode;

public static class Problem26
{
    // Note: the solution must be O(1) in space, reusing the original array (fixed size) and
    // shifting the elements to the left portion of the array while removing duplicates
    public static int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var lastItem = nums[0];
        var length = nums.Length;
        int index = 1, freeIndex = 1;

        while (index < nums.Length)
        {
            if (nums[index] != lastItem)
            {
                nums[freeIndex] = nums[index];
                freeIndex++;
                lastItem = nums[index];
            }
            else
            {
                length--;
            }

            index++;
        }

        return length;
    }
}
