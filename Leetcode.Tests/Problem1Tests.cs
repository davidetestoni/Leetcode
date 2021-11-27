using System.Linq;
using Xunit;

namespace Leetcode.Tests;

public class Problem1Tests
{
    [Theory]
    [InlineData(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [InlineData(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [InlineData(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void Problem1_Tests(int[] nums, int target, int[] result)
    {
        Assert.True(Problem1.TwoSum(nums, target).SequenceEqual(result));
    }
}
