using BasicStructurePractices;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructureTests;

[TestClass]
public sealed class LinkedListStackTest
{
    [TestMethod]
    public void LLS_Push_Should_AddBeforeHead()
    {
        //ARRANGE
        var l = new LinkedListStack<string>();

        //ACT
        l.Push("Hello");
        l.Push("From");
        l.Push("Mars");

        //ASSERT
        string.Join(" ", [.. l]).SequenceEqual("Mars From Hello");
    }

    [TestMethod]
    public void LLS_Pop_Should_Return_RemoveAndReturnFirstElement()
    {
        //ARRANGE
        var l = new LinkedListStack<string>();

        l.Push("Hello");
        l.Push("From");
        l.Push("Mars");

        //ACT
        var uut = l.Pop();

        //ASSERT
        uut.Should().Be("Mars");
        l.Should().HaveCount(2);
    }

    [TestMethod]
    public void LLS_Pop_When_EmptyList_Should_Throw_InvalidOperationException()
    {
        //ARRANGE
        var l = new LinkedListStack<string>();
        //ACT
        Action uut = () => l.Pop();

        //ASSERT
        uut.Should().Throw<InvalidOperationException>();
        l.Should().BeEmpty();
    }

    [TestMethod]
    public void LLS_Peek_Should_Return_ReturnFirstElement_WithoutRemovingAnyElement()
    {
        //ARRANGE
        var l = new LinkedListStack<string>();

        l.Push("Hello");
        l.Push("From");
        l.Push("Mars");

        //ACT
        var uut = l.Peek();

        //ASSERT
        uut.Should().Be("Mars");
        l.Should().HaveCount(3);
    }

    [TestMethod]
    public void LLS_Peek_When_EmptyList_Should_Throw_InvalidOperationException()
    {
        //ARRANGE
        var l = new LinkedListStack<string>();
        //ACT
        Action uut = () => l.Peek();

        //ASSERT
        uut.Should().Throw<InvalidOperationException>();
        l.Should().BeEmpty();
    }

    //-----------------------
    //Exercise: Brackets
    //-----------------------
    /* Given a string made up of the following brackets: () [] {},
     * determine whether the brackets properly match
     */

    [TestMethod]
    [DataRow("[()]", true)]
    [DataRow("(()())", true)]
    [DataRow("{]", false)]
    [DataRow("[()]))()", false)]
    [DataRow("[]{}({})", true)]
    public void LLS_BracketsProblem(string input, bool expectedRes)
    {
        var res = this.Brackets(input);

        res.Should().Be(expectedRes, $"for input: {input}, expected res: {expectedRes}");
    }

    private bool Brackets(string input)
    {
        var l = new LinkedListStack<string>();
        var closeB = ")]}";
        var isOk = true;

        foreach (var c in input)
        {
            if (closeB.Contains(c.ToString()) is false)
                l.Push(c.ToString());
            else
            {
                if (isOk is false || l.Count == 0)
                    return false;

                var openB = c.ToString() switch
                {
                    ")" => "(",
                    "]" => "[",
                    "}" => "{",
                    _ => throw new InvalidOperationException()
                };

                isOk &= openB == l.Pop();
            }
        }

        return isOk;
    }
}
