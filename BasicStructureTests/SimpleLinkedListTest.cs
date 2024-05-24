using BasicStructurePractices;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicStructureTests;

[TestClass]
public sealed class SimpleLinkedListTest
{
    [TestMethod]
    public void SLL_Should_Init()
    {
        //ARRANGE, ACT
        var l = new SimpleLinkedList<string>();

        //ASSERT
        l.Count.Should().Be(0);
        l.IsEmpty.Should().BeTrue();
    }

    [TestMethod]
    public void SLL_Add_Should_Add_New_Items()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>
        {
            //ACT
            "Hello",
            "World",
            "!!"
        };

        //ASSERT
        l.Count.Should().Be(3);
        string.Join(" ", l.ToArray()).Should().Be("Hello World !!");
    }

    [TestMethod]
    public void SLL_ItemAt_Should_Return_ItemAtIndex()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>
        {
            "Hello",
            "Amazing",
            "World",
            "!!"
        };

        //ACT
        var uut = l.ItemAt(1);

        //ASSERT
        l.Count.Should().Be(4);
        uut.Should().Be("Amazing");
    }

    [TestMethod]
    public void SSL_ItemAt_Given_InvalidIndex_Should_Throw_ArgumentOutOfRangeException()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>
        {
            "Hello",
            "Amazing",
            "World",
            "!!"
        };

        var action = () => l.ItemAt(10);

        //ACT, ASSERT
        action.Should().Throw<ArgumentOutOfRangeException>();
        l.Count.Should().Be(4);
    }

    [TestMethod]
    public void SSL_ItemAt_When_ListIsEmpty_Should_Throw_ArgumentOutOfRangeException()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>();

        var action = () => l.ItemAt(10);

        //ACT, ASSERT
        action.Should().Throw<ArgumentOutOfRangeException>();
        l.IsEmpty.Should().BeTrue();
    }

    [TestMethod]
    public void SSL_Remove_Should_RemoveItem()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>
        {
            "Hello",
            "Amazing",
            "World",
            "!!"
        };

        //ACT
        var uut = l.Remove("Amazing");

        //ASSERT
        l.Should().HaveCount(3);
        string.Join(" ", l.ToArray()).Should().Be("Hello World !!");
    }

    [TestMethod]
    public void SSL_Remove_When_RemovingTheHeadNode_Should_RemoveItem()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>
        {
            "Hello",
            "Amazing",
            "World",
            "!!"
        };

        //ACT
        var uut = l.Remove("Hello");

        //ASSERT
        l.Should().HaveCount(3);
        string.Join(" ", l.ToArray()).Should().Be("Amazing World !!");
    }

    [TestMethod]
    public void SSL_Remove_When_RemovingTailNode_Should_RemoveItem()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>
        {
            "Hello",
            "Amazing",
            "World",
            "!!"
        };

        //ACT
        var uut = l.Remove("!!");

        //ASSERT
        l.Should().HaveCount(3);
        string.Join(" ", l.ToArray()).Should().Be("Hello Amazing World");
    }

    [TestMethod]
    public void SSL_Remove_When_IsEmpty_Should_DoNothing()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>();

        //ACT
        var uut = l.Remove("!!");

        //ASSERT
        l.Should().BeEmpty();
        string.Join(" ", l.ToArray()).Should().BeEmpty();
    }

    [TestMethod]
    public void SSL_Remove_When_ItemNotFound_Should_Throw()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>
        {
            "Hello",
            "Amazing",
            "World",
            "!!"
        };

        //ACT, ASSERT
        Action uut = () => l.Remove("LoremA");
        uut.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void SLL_AddFirst_Should_AddNewItemBeforeHead()
    {
        //ARRANGE
        var l = new SimpleLinkedList<string>();
        l.Add("Hello");
        l.Add("Amazing");
        l.Add("World");
        l.Add("!!");

        //ACT
        l.AddFirst("Bananas");

        //ASSERT
        l.First().Should().Be("Bananas");
    }
}
