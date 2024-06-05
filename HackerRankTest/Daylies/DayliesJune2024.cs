﻿using FluentAssertions;
using PracticesAndSolutions.HackerRank.Daylies;
using PracticesAndSolutions.HackerRank.ProblemSolving;

namespace HackerRankTest.Daylies;

[TestClass]
public sealed class DayliesJune2024
{
    [TestMethod]
    [DataRow(20, 23, 6, 2)]
    [DataRow(13, 45, 3, 33)]
    public void BeautifulDaysAtTheMoviesTest(int i, int j, int k, int expectedRes)
    {
        var uut = BeautifulDaysAtTheMovies.BeautifulDays(i, j, k);

        uut.Should().Be(expectedRes);
    }

    [TestMethod]
    [DataRow(1, 2)]
    [DataRow(2, 5)]
    [DataRow(3, 9)]
    [DataRow(4, 15)]
    [DataRow(5, 24)]
    [DataRow(6, 37)]
    [DataRow(7, 56)]
    public void ViralAdvertisingProblemTest(int day, int res)
    {
        var uut = ViralAdvertisingProblem.ViralAdvertising(day);

        uut.Should().Be(res);
    }

    [TestMethod]
    [DataRow(5, 3, 1)]
    [DataRow(6, 2, 1)]
    [DataRow(5, 4, 0)]
    [DataRow(11, 9, 1)]
    [DataRow(7, 5, 1)]
    [DataRow(5, 7, 0)]
    public void DrawingBookProblemTest(int n, int p, int res)
    {
        var uut = DrawingBook.PageCount(n, p);

        uut.Should().Be(res);
    }
}