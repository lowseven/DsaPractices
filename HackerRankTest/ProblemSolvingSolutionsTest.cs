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

    [TestMethod]
    [DataRow(2016, "12.09.2016")]
    [DataRow(2017, "13.09.2017")]
    [DataRow(1918, "26.09.1918")]
    [DataRow(1800, "12.09.1800")]
    public void DayOfProgrammerBetterBetterSolutionProblemTest(int year, string res)
    {
        var uut = DayOfTheProgrammerProblem.DayOfProgrammerBetterBetterSolution(year);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 3, 10, 2, 9 }, 1, 12, "5")]
    [DataRow(new int[] { 3, 10, 2, 9 }, 1, 7, "Bon Appetit")]
    public void BonAppetitProblemSolutionProblemTest(int[] bill, int k, int b, string res)
    {
        var uut = BonAppetitProblem.BonAppetit(bill.ToList(), k, b);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 1, 2, 1, 3, 2 }, 2)]
    [DataRow(new int[] { 10, 20, 20, 10, 10, 30, 50, 10, 20 }, 3)]
    public void SockMerchantProblemTest(int[] socks, int res)
    {
        var uut = SockMerchantProblem.SockMerchant(0, socks.ToList());

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 40, 50, 60 }, new int[] { 5, 8, 12 }, 60, 58)]
    [DataRow(new int[] { 3, 1 }, new int[] { 5, 2, 8 }, 10, 9)]
    public void GetMoneySpentProblemTest(int[] keyboards, int[] drives, int b, int res)
    {
        var uut = GetMoneySpentProblem.GetMoneySpent(keyboards, drives, b);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow("abcac", 10, 4)]
    [DataRow("aba", 10, 7)]
    [DataRow("a", 1000000000000, 1000000000000)]
    [DataRow("ceebbcb", 817723, 0)]
    [DataRow("gfcaaaecbg", 547602, 164280)]
    [DataRow("epsxyyflvrrrxzvnoenvpegvuonodjoxfwdmcvwctmekpsnamchznsoxaklzjgrqruyzavshfbmuhdwwmpbkwcuomqhiyvuztwvq", 549382313570, 16481469408)]
    public void RepeatedStringsProblemTest(string s, long n, long res)
    {
        var uut = RepeatedStringsProblem.RepeatedString(s, n);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(4, new int[] { 1, 6, 3, 5, 2 }, 2)]
    [DataRow(1, new int[] { 1, 2, 3, 3, 2 }, 2)]
    [DataRow(3, new int[] { 1, 2, 3, 3, 2 }, 0)]
    [DataRow(4, new int[] { 1, 6, 3, 5, 2 }, 2)]
    [DataRow(7, new int[] { 2, 5, 4, 5, 2 }, 0)]
    public void CatAndMouseProblemTest(int k, int[] height, int res)
    {
        var uut = TheHurdleRaceProblem.HurdleRace(k, height.ToList());

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 }, "abc", 9)]
    [DataRow(new int[] { 1, 3, 1, 3, 1, 4, 1, 3, 2, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 7 }, "zaba", 28)]
    public void DesignerPdfViewerProblemTest(int[] height, string word, int res)
    {
        var uut = DesignerPdfViewerProblem.DesignerPdfViewer(height.ToList(), word);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(4, 6, 2, 3)]
    [DataRow(5, 2, 1, 2)]
    [DataRow(5, 2, 2, 3)]
    [DataRow(3, 7, 3, 3)]
    [DataRow(3, 7, 2, 2)]
    public void SaveThePrisionerProblemTest(int n, int m, int s, int res)
    {
        var uut = SaveThePrisionerProblem.SaveThePrisoner(n, m, s);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 1, 2, 3 }, 2, new int[] { 0, 1, 2 }, new int[] { 2, 3, 1 })]
    [DataRow(new int[] { 1, 2, 3 }, 3, new int[] { 0, 1, 2 }, new int[] { 1, 2, 3 })]
    public void CircularArrayRotationProblemTest(int[] a, int k, int[] queries, int[] res)
    {
        var uut = CircularArrayRotationProblem.CircularArrayRotation(a.ToList(), k, queries.ToList());

        uut.SequenceEqual(res).Should().BeTrue();
    }

    [TestMethod]
    [DataRow(new int[] { 0, 0, 0, 0, 1, 0 }, 3)]
    [DataRow(new int[] { 0, 0, 1, 0, 0, 1, 0 }, 4)]
    public void JumpingOntheCloudsProblemTest(int[] a, int res)
    {
        var uut = JumpingOntheCloudsProblem.JumpingOnClouds(a.ToList());

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(new int[] { 2, 3, 1 }, new int[] { 2, 3, 1 })]
    [DataRow(new int[] { 4, 3, 5, 1, 2 }, new int[] { 1, 3, 5, 4, 2 })]
    public void JumpingOntheCloudsProblemTest(int[] a, int[] res)
    {
        var uut = PermutationEquationProblem.PermutationEquation(a.ToList());

        uut.SequenceEqual(res).Should().BeTrue();
    }
}
