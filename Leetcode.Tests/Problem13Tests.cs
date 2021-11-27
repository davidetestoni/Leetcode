using Xunit;

namespace Leetcode.Tests;

public class Problem13Tests
{
    [Theory]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("IX", 9)]
    [InlineData("LVIII", 58)]
    [InlineData("MCMXCIV", 1994)]
    public void Problem13_Tests(string s, int valid)
    {
        Assert.True(Problem13.RomanToInt(s) == valid);
    }
}
