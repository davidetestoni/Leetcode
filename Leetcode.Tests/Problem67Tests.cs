using Xunit;

namespace Leetcode.Tests;

public class Problem67Tests
{
    [Theory]
    [InlineData("11", "1", "100")]
    [InlineData("1010", "1011", "10101")]
    public void Problem67_Tests(string a, string b, string output)
    {
        Assert.Equal(output, Problem67.AddBinary(a, b));
    }
}
