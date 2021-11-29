using System.Linq;
using Xunit;

namespace Leetcode.Tests;

public class Problem66Tests
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3 }, new int[] { 1, 2, 4 })]
    [InlineData(new int[] { 4, 3, 2, 1 }, new int[] { 4, 3, 2, 2 })]
    [InlineData(new int[] { 0 }, new int[] { 1 })]
    [InlineData(new int[] { 9 }, new int[] { 1, 0 })]
    public void Problem66_Tests(int[] digits, int[] output)
    {
        Assert.True(Problem66.PlusOne(digits).SequenceEqual(output));
    }
}
