using System;
using System.Linq;
using Xunit;

namespace Leetcode.Tests;

public class Problem26Tests
{
    [Theory]
    [InlineData(new int[] { 1, 1, 2 }, new int[] { 1, 2, 0 }, 2)]
    [InlineData(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, new int[] { 0, 1, 2, 3, 4, 0, 0, 0, 0, 0 }, 5)]
    public void Problem26_Tests(int[] nums, int[] output, int k)
    {
        var unique = Problem26.RemoveDuplicates(nums);

        Assert.Equal(k, unique);

        var leftNums = nums.Take(k);
        var leftOutput = output.Take(k);

        Assert.True(leftNums.SequenceEqual(leftOutput));
    }
}
