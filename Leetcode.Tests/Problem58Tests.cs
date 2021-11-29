using Xunit;

namespace Leetcode.Tests;

public class Problem58Tests
{
    [Theory]
    [InlineData("Hello World", 5)]
    [InlineData("   fly me   to   the moon  ", 4)]
    [InlineData("luffy is still joyboy", 6)]
    public void Problem58_Tests(string s, int output)
    {
        Assert.Equal(output, Problem58.LengthOfLastWord(s));
    }
}
