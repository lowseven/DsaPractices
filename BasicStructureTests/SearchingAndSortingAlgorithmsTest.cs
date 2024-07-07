using BasicStructurePractices;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructureTests;

[TestClass]
public class SearchingAndSortingAlgorithmsTest
{
    [TestMethod]
    [DataRow(new int[] { 517, 936, 794, 378, 352, 364, 642, 464, 375, 473, 41, 44, 630, 580, 27 }, 630)]
    [DataRow(new int[] { 517, 936, 794, 378, 352, 364, 642, 464, 375, 473, 41, 44, 630, 580, 27 }, 794)]
    public void BinaryTreeTest(int[] array, int value)
    {
        var a = array.ToList();
        
        a.Sort();

        SearchingAndSortingAlgorithm.BinarySearch(a.ToArray(), value).Should().BeTrue();
    }
}
