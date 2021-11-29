namespace Leetcode;

public static class Problem35
{
    // O(log N) complexity, a.k.a. use binary search
    public static int SearchInsert(int[] nums, int target)
    {
        return SearchInsert(nums, 0, nums.Length - 1, target);
    }

    private static int SearchInsert(int[] nums, int min, int max, int target)
    {
        var length = max - min;

        // If we are down to the last element
        if (length == 0)
        {
            if (target <= nums[min])
            {
                return min;
            }

            return min + 1;
        }

        var mid = (min + max) / 2;
        
        if (target == nums[mid])
        {
            return mid;
        }
        else if (target < nums[mid])
        {
            // Search in left half
            return SearchInsert(nums, min, mid == min ? min : mid - 1, target);
        }

        // Search in right half
        return SearchInsert(nums, mid + 1, max, target);
    }
}
