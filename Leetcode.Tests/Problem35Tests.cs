using Xunit;

namespace Leetcode.Tests;

public class Problem35Tests
{
    [Theory]
    [InlineData(new int[] { 3, 5, 7, 9, 10 }, 8, 3)]
    [InlineData(new int[] { 1, 3 }, 2, 1)]
    [InlineData(new int[] { 1, 3 }, 0, 0)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 5, 2)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 2, 1)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 7, 4)]
    [InlineData(new int[] { 1, 3, 5, 6 }, 0, 0)]
    [InlineData(new int[] { 1 }, 0, 0)]
    public void Problem35_Tests(int[] nums, int target, int output)
    {
        Assert.Equal(output, Problem35.SearchInsert(nums, target));
    }
}
