using Xunit;

namespace Leetcode.Tests;

public class Problem14Tests
{
    [Theory]
    [InlineData(new string[] { "flower", "flow", "flight" }, "fl")]
    [InlineData(new string[] { "dog", "racecar", "car" }, "")]
    public void Problem14_Tests(string[] strs, string prefix)
    {
        Assert.True(Problem14.LongestCommonPrefix(strs) == prefix);
    }
}
