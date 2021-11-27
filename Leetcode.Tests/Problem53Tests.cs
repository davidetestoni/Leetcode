using Xunit;

namespace Leetcode.Tests;

public class Problem53Tests
{
    [Theory]
    [InlineData(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
    [InlineData(new int[] { 1 }, 1)]
    [InlineData(new int[] { 5, 4, -1, 7, 8 }, 23)]
    public void Problem53_Tests(int[] nums, int sum)
    {
        Assert.True(Problem53.MaxSubArray(nums) == sum);
    }
}
