using Xunit;

namespace Leetcode.Tests;

public class Problem9Tests
{
    [Theory]
    [InlineData(121, true)]
    [InlineData(-121, false)]
    [InlineData(10, false)]
    [InlineData(-101, false)]
    public void Problem9_Tests(int x, bool valid)
    {
        Assert.True(Problem9.IsPalindrome(x) == valid);
    }
}
