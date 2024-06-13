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
    [DataRow(new[] { 3, 4 }, new int[] { 24, 48 }, 2)]
    [DataRow(new[] { 2, 4 }, new int[] { 16, 32, 96 }, 3)]
    public void BetweenTwoSetsProblem(int[] set1, int[] set2, int res)
    {
        var uut = BetweenTwoSets.GetTotalX(set1.ToList(), set2.ToList());

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new[] { 10, 5, 20, 20, 4, 5, 2, 25, 1 }, new int[] { 2, 4 })]
    [DataRow(new[] { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 }, new int[] { 4, 0 })]
    public void BreakingBestAndWorstRecordsProblemTest(int[] list, int[] res)
    {
        var uut = BreakingBestAndWorstRecordsProblem.BreakingRecords(list.ToList());

        uut.SequenceEqual(res).Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new[] { 1, 2, 1, 3, 2 }, 3, 2, 2)]
    [DataRow(new[] { 1, 1, 1, 1, 1, 1 }, 3, 2, 0)]
    [DataRow(new[] { 4 }, 4, 1, 1)]
    [DataRow(new[] { 2, 2, 2, 1, 3, 2, 2, 3, 3, 1, 4, 1, 3, 2, 2, 1, 2, 2, 4, 2, 2, 3, 5, 3, 4, 3, 2, 1, 4, 5, 4 }, 10, 4, 7)]
    public void TheBirthdayBarProblemTest(int[] list, int day, int month, int res)
    {
        var uut = TheBirthdayBarProblem.Birthday(list.ToList(), day, month);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(6, 5, new[] { 1, 2, 3, 4, 5, 6 }, 3)]
    [DataRow(6, 3, new[] { 1, 3, 2, 6, 1, 2, }, 5)]
    public void DivisibleSumPairsProblemTest(int n, int k, int[] ar, int res)
    {
        var uut = DivisibleSumPairsProblem.DivisibleSumPairs(n, k, ar.ToList());

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new[] { 1, 4, 4, 4, 5, 3 }, 4)]
    [DataRow(new[] { 1, 1, 2, 2, 3 }, 1)]
    [DataRow(new[] { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 }, 3)]
    public void MigratoryBirdsProblemTest(int[] ar, int res)
    {
        var uut = MigratoryBirdsProblem.MigratoryBirds(ar.ToList());

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(2016, "12.09.2016")]
    [DataRow(2017, "13.09.2017")]
    [DataRow(1918, "26.09.1918")]
    [DataRow(1800, "12.09.1800")]
    public void DayOfTheProgrammerProblemTest(int year, string res)
    {
        var uut = DayOfTheProgrammerProblem.DayOfProgrammer(year);

        uut.Should().Be(res);
    }
}
