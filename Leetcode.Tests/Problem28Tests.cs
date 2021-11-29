using Xunit;

namespace Leetcode.Tests;

public class Problem28Tests
{
    [Theory]
    [InlineData("hello", "ll", 2)]
    [InlineData("aaaaa", "bba", -1)]
    [InlineData("", "", 0)]
    public void Problem28_Tests(string haystack, string needle, int index)
    {
        Assert.Equal(index, Problem28.StrStr(haystack, needle));
    }
}
