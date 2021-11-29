using System;
using System.Linq;
using Xunit;

namespace Leetcode.Tests;

public class Problem27Tests
{
    [Theory]
    [InlineData(new int[] { 3, 2, 2, 3 }, 3, new int[] { 2, 2 }, 2)]
    [InlineData(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, new int[] { 0, 1, 4, 0, 3, 0, 0, 0 }, 5)]
    public void Problem27_Tests(int[] nums, int val, int[] output, int k)
    {
        var unique = Problem27.RemoveElement(nums, val);

        Assert.Equal(k, unique);

        var leftNums = nums.Take(k).ToList();
        leftNums.Sort();

        var leftOutput = output.Take(k).ToList();
        leftOutput.Sort();

        Assert.True(leftNums.SequenceEqual(leftOutput));
    }
}
