using Xunit;

namespace Leetcode.Tests;

public class Problem20Tests
{
    [Theory]
    [InlineData("()[]{}", true)]
    [InlineData("(", false)]
    [InlineData("(]", false)]
    [InlineData("([)]", false)]
    [InlineData("{[]}", true)]
    public void Problem20_Tests(string s, bool valid)
    {
        Assert.True(Problem20.ValidateParenthesis(s) == valid);
    }
}
