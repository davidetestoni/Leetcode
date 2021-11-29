namespace Leetcode;

public static class Problem27
{
    // Note: the solution must be O(1) in space, reusing the original array (fixed size) and
    // shifting the elements to the left portion of the array while removing duplicates
    public static int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var length = nums.Length;
        int index = 0, freeIndex = 0;

        while (index < nums.Length)
        {
            if (nums[index] != val)
            {
                nums[freeIndex] = nums[index];
                freeIndex++;
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
