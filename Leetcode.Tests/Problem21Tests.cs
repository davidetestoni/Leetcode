using System;
using System.Linq;
using Xunit;

namespace Leetcode.Tests;

public class Problem21Tests
{
    // # of nodes in lists in [0, 50]
    // -100 <= Node.val <= 100
    // list1 and list2 sorted in non-decreasing order

    [Theory]
    [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
    [InlineData(new int[] {  }, new int[] {  }, new int[] {  })]
    [InlineData(new int[] {  }, new int[] { 0 }, new int[] { 0 })]
    public void Problem21_Tests(int[] first, int[] second, int[] output)
    {
        var list1 = Problem21.ListNode.FromArray(first);
        var list2 = Problem21.ListNode.FromArray(second);
        var merged = Problem21.MergeTwoLists(list1, list2);

        if (output.Length == 0)
        {
            Assert.Null(merged);
        }
        else
        {
            var array = merged.ToArray();
            Assert.True(array.SequenceEqual(output));
        }
    }
}
