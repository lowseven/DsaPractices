using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using PracticesAndSolutions.Leetcode;

namespace LeetCodeTest.Easy;

[TestClass]
public class ArraysTest
{
    [TestMethod]
    [DataRow(new int[] { 1, 1, 2 }, 2)]
    [DataRow(new int[] { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 }, 5)]
    public void RemoveDuplicatesFromSortedArrayProblemTest(int[] arr, int res)
    {
        var uut = RemoveDuplicatesFromSortedArrayProblem.RemoveDuplicates(arr);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 3, 2, 2, 3 }, 3, 2)]
    [DataRow(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2, 5)]
    public void RemoveElementsProblemTest(int[] arr, int val, int res)
    {
        var uut = RemoveElementProblem.RemoveElement(arr, val);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    public void TwoIntegerSumProblemTest(int[] arr, int val, int[] res)
    {
        var uut = TwoIntegerSumProblem.TwoSum(arr, val);

        uut.SequenceEqual(res).Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
    public void ProductOfArrayExceptShelfProblemTest(int[] arr, int[] res)
    {
        var uut = ProductOfArrayExceptShelfProblem.ProductExceptSelf(arr);

        uut.SequenceEqual(res).Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3, 4 }, new int[] { 1, 2, 3, 4, 1, 2, 3, 4 })]
    public void ConcatenationOfArrayProblemTest(int[] arr, int[] res)
    {
        var uut = ConcatenationOfArrayProblem.GetConcatenation(arr);

        uut.SequenceEqual(res).Should().BeTrue();
    }

}
