using FluentAssertions;
using PracticesAndSolutions.Codility;

namespace CodilityTest
{
    [TestClass]
    public class EasyProblemsTest
    {
        [TestMethod]
        [DataRow(1, 0)]
        [DataRow(529, 4)]
        [DataRow(9, 2)]
        [DataRow(20, 1)]
        [DataRow(32, 0)]
        [DataRow(1041, 5)]
        [DataRow(32, 0)]
        [DataRow(1610612737, 28)]
        [DataRow(1376796946, 5)]
        public void BinaryGapProblemTest(int N, int res)
        {
            var uut = BinaryGapProblem.Solution(N);
            uut.Should().Be(res);   
        }

        [TestMethod]
        [DataRow(new int[] { 3, 8, 9, 7, 6 }, 3, new int[] { 9, 7, 6, 3, 8 })]
        [DataRow(new int[] { 1, 2, 3, 4 }, 4, new int[] { 1, 2, 3, 4 })]
        public void CyclicRotationTest(int[] N, int K, int[] res)
        {
            var uut = CyclicRotationProblem.Solution(N, K);
            uut.SequenceEqual(res).Should().BeTrue();
        }

        [TestMethod]
        [DataRow(new int[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
        public void OddOcurrencyInArrayProblemTest(int[] N, int res)
        {
            var uut = OddOcurrencyInArrayProblem.Solution(N);
            uut.Should().Be(res);
        }

        [TestMethod]
        [DataRow(10, 85, 30, 3 )]
        [DataRow(1, 1000000000, 1, 999999999)]
        public void FrogJmpProblemTest(int X, int Y, int D, int res)
        {
            var uut = FrogJmpProblem.Solution(X, Y, D);
            uut.Should().Be(res);
        }

        [TestMethod]
        [DataRow(new int[] { 2, 3, 1, 5 }, 4)]
        public void FrogJmpProblemTest(int[] X, int res)
        {
            var uut = PermMissingElementProblem.Solution(X);
            uut.Should().Be(res);
        }

        [TestMethod]
        [DataRow(new int[] { 3, 1, 2, 4, 3 }, 1)]
        public void TapeEquilibriumProblemTest(int[] X, int res)
        {
            var uut = TapeEquilibriumProblem.Solution(X);
            uut.Should().Be(res);
        }
    }
}