using Xunit;

namespace Leetcode.Tests;

public class Problem69Tests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 1)]
    [InlineData(4, 2)]
    [InlineData(8, 2)]
    [InlineData(2147395599, 46339)]
    public void Problem69_Tests(int x, int output)
    {
        Assert.Equal(output, Problem69.MySqrt(x));
    }
}
