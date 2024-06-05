using FluentAssertions;
using PracticesAndSolutions.HackerRank.ProblemSolving;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankTest;

[TestClass]
public class ProblemSolvingSolutionsTest
{
    [TestMethod]
    [DataRow("1 3 5 7 9", "16 24")]
    [DataRow("1 2 3 4 5", "10 14")]
    [DataRow("7 69 2 221 8974", "299 9271")]
    [DataRow("942381765 627450398 954173620 583762094 236817490", "2390411747 3107767877")]
    public void MinMaxSumProblemTest(string input, string expectedRes)
    {
        var list = input.Split(" ").Select(int.Parse).ToList();
        var res = MinMaxSum.MiniMaxSum([.. list]);

        $"{res.Item1} {res.Item2}".Should().Be(expectedRes);
    }

    [TestMethod]
    [DataRow(new int[] { 3, 2, 1, 3 }, 2)]
    public void BirthdayCakeCandlesProblemTest(int[] candles, int res)
    {
        var uut = BirthdayCandles.BirthdayCakeCandles(candles.ToList());

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 73, 67, 38, 33 }, new int[] { 75, 67, 40, 33 })]
    public void GradingStudentsProblemTest(int[] grades, int[] expectedGrades)
    {
        var uut = GradingProblem.GradingStudents(grades.ToList());

        uut.SequenceEqual(expectedGrades).Should().BeTrue();
    }

    [TestMethod]
    [DataRow(7, 11, 5, 15, new int[] { -2, 2, 1 }, new int[] { 5, -6 }, "1 1")]
    public void AppleAndOrangeProblemTest(int s, int t, int a, int b, int[] apples, int[] oranges, string expectedRes)
    {
        var uut = AppleAndOrangeProblem.CountApplesAndOranges(s, t, a, b, apples.ToList(), oranges.ToList());

        uut.Should().Be(expectedRes);
    }

    [TestMethod]
    [DataRow(0, 3, 4, 2, "YES")]
    [DataRow(0, 2, 5, 3, "NO")]
    [DataRow(6644, 5868, 8349, 3477, "NO")]
    public void KangarooProblemTest(int x1, int v1, int x2, int v2, string expectedRes)
    {
        var uut = KangarooProblem.Kangaroo(x1, v1, x2, v2);

        uut.Should().Be(expectedRes);
    }

    [TestMethod]
    [DataRow(new[] { 2, 6 }, new int[] { 24, 36 }, 2)]
    public void BetweenTwoSetsProblem(int[] set1, int[] set2, int res)
    {
        var uut = BetweenTwoSets.GetTotalX(set1.ToList(), set2.ToList());

        uut.Should().Be(res);
    }
}
