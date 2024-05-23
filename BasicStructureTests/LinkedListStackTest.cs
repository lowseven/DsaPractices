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
}
