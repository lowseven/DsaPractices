using BasicStructurePractices;
using FluentAssertions;

namespace BasicStructureTests;

[TestClass]
public class DoubledLinkedListTest
{
    [TestMethod]
    public void DLL_Add_Should_AddNewItem()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ACT
        l.Add("Oh");
        l.Add("Bananas");
        l.Add("!!!");

        //ASSERT
        l.Count.Should().Be(3);
        l.Should().HaveCount(3);
    }

    [TestMethod]
    public void DLL_Clear_Should_EmptyTheList()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>
        {
            "Oh",
            "Bananas",
            "!!!"
        };

        //ACT
        l.Clear();

        //ASSERT
        l.Count.Should().Be(0);
        l.Any().Should().BeFalse();
    }

    [TestMethod]
    public void DLL_IsEmpty_When_NoAddedItems_Should_Return_True()
    {
        //ARRANGE, ACT 
        var l = new DoubleLinkedList<string>();

        //ASSERT
        l.Should().BeEmpty();
        l.Count.Should().Be(0);
        l.IsEmpty.Should().BeTrue();
    }

    [TestMethod]
    public void DLL_AddLast_Should_AddAfterLastElement()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ACT
        l.AddLast("Oh");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ASSERT
        l.Count.Should().Be(3);
        l.Should().HaveCount(3);
        l.Last().Should().Be("!!!");
        string.Join(" ", l.ToArray()).Should().Be("Oh Bananas !!!");
    }

    [TestMethod]
    public void DLL_AddFirst_Should_AddBeforeFirstElement()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ACT
        l.AddFirst("Oh");
        l.AddFirst("Bananas");
        l.AddFirst("!!!");

        //ASSERT
        l.Count.Should().Be(3);
        l.Should().HaveCount(3);
        l.First().Should().Be("!!!");
        string.Join(" ", l.ToArray()).Should().Be("!!! Bananas Oh");
    }

    [TestMethod]
    public void DLL_PeekFirst_Should_Return_FirstElement()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.PeekFirst();

        //ASSERT
        l.Count.Should().Be(3);
        l.Should().HaveCount(3);
        uut.Should().Be("Oh");
    }

    [TestMethod]
    public void DLL_PeekFirst_When_ListIsEmpty_Should_Throw_InvalidOperationException()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ASSERT, ACT
        Action uut = () => l.PeekFirst();
        uut.Should().Throw<InvalidOperationException>();
        l.Count.Should().Be(0);
        l.Should().BeEmpty();
    }

    [TestMethod]
    public void DLL_PeekLast_Should_Return_LastElement()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.PeekLast();

        //ASSERT
        l.Count.Should().Be(3);
        l.Should().HaveCount(3);
        uut.Should().Be("!!!");
    }

    [TestMethod]
    public void DLL_PeekLast_When_ListIsEmpty_Should_Throw_InvalidOperationException()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ASSERT, ACT
        Action uut = () => l.PeekLast();
        uut.Should().Throw<InvalidOperationException>();
        l.Count.Should().Be(0);
        l.Should().BeEmpty();
    }

    [TestMethod]
    public void DLL_RemoveFirst_Should_RemoveFirstElement()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.RemoveFirst();

        //ASSERT
        l.Count.Should().Be(2);
        l.Should().HaveCount(2);
        uut.Should().Be("Oh");
    }

    [TestMethod]
    public void DLL_RemoveFirst_When_Empty_Should_Throw_InvalidOperationException()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ACT, ASSERT
        Action uut = () => l.RemoveFirst();

        l.Count.Should().Be(0);
        l.Should().HaveCount(0);
        uut.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void DLL_RemoveFirst_When_ListHaveOneItem_Should_Set_TailToNull()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");

        //ACT, ASSERT
        var uut = l.RemoveFirst();

        l.Count.Should().Be(0);
        l.Should().HaveCount(0);
        uut.Should().Be("Oh");
    }

    [TestMethod]
    public void DLL_RemoveLast_Should_RemoveLastElement()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.RemoveLast();

        //ASSERT
        l.Count.Should().Be(2);
        l.Should().HaveCount(2);
        uut.Should().Be("!!!");
    }

    [TestMethod]
    public void DLL_RemoveLast_When_Empty_Should_Throw_InvalidOperationException()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ACT, ASSERT
        Action uut = () => l.RemoveLast();

        l.Count.Should().Be(0);
        l.Should().HaveCount(0);
        uut.Should().Throw<InvalidOperationException>();
    }

    [TestMethod]
    public void DLL_RemoveLast_When_ListHaveOneItem_Should_Set_TailToNull()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");

        //ACT, ASSERT
        var uut = l.RemoveLast();

        l.Count.Should().Be(0);
        l.Should().HaveCount(0);
        uut.Should().Be("Oh");
    }

    [TestMethod]
    public void DLL_Remove_When_DeleteFirstElement_Should_RemoveItem()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.Remove("Oh");

        uut.Should().Be("Oh");
        l.Count.Should().Be(2);
        l.Count().Should().Be(2);
    }

    [TestMethod]
    public void DLL_Remove_When_DeleteLastElement_Should_RemoveItem()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.Remove("!!!");

        uut.Should().Be("!!!");
        l.Count.Should().Be(2);
        l.Count().Should().Be(2);
    }

    [TestMethod]
    public void DLL_Remove_When_DeleteSomethingInTheMiddle_Should_RemoveItem()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.Remove("Bananas");

        uut.Should().Be("Bananas");
        l.Count.Should().Be(2);
        l.Count().Should().Be(2);
    }

    [TestMethod]
    public void DLL_Remove_When_EmptyList_Should_ReturnNull()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ACT
        var uut = l.Remove("Bananas");

        uut.Should().BeNull();
        l.IsEmpty.Should().BeTrue();
        l.Any().Should().BeFalse();
    }

    [TestMethod]
    public void DLL_RemoveAt_When_GivingValidIndex_Should_RemoveItemAtGivenIndex()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("My");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.RemoveAt(1);

        uut.Should().Be("My");
        l.Count.Should().Be(3);
        l.Count().Should().Be(3);
    }

    [TestMethod]
    public void DLL_RemoveAt_When_IndexIsAtTheEnd_Should_RemoveItemAtGivenIndex()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("My");
        l.AddLast("Delicious");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.RemoveAt(3);

        uut.Should().Be("Bananas");
        l.Count.Should().Be(4);
        l.Count().Should().Be(4);
    }

    [TestMethod]
    public void DLL_IndexOf_Should_ReturnItemIndex()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("My");
        l.AddLast("Delicious");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.IndexOf("Bananas");

        uut.Should().Be(3);
    }

    [TestMethod]
    public void DLL_IndexOf_When_EmptyList_Should_ReturnInvalidIndex()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ACT
        var uut = l.IndexOf("Apple");

        uut.Should().Be(-1);
    }

    [TestMethod]
    public void DLL_IndexOf_When_ItemNotExistInTheList_Should_ReturnInvalidIndex()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("My");
        l.AddLast("Delicious");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.IndexOf("Apple");

        uut.Should().Be(-1);
    }

    [TestMethod]
    public void DLL_Contains_Should_ReturnTrue()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("My");
        l.AddLast("Delicious");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.Contains("Bananas");

        uut.Should().BeTrue();
    }

    [TestMethod]
    public void DLL_Contains_When_EmptyList_Should_ReturnFalse()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();

        //ACT
        var uut = l.IndexOf("Bananas");

        uut.Should().Be(-1);
    }

    [TestMethod]
    public void DLL_Contains_When_ItemNotExistInTheList_Should_ReturnInvalidIndex()
    {
        //ARRANGE
        var l = new DoubleLinkedList<string>();
        l.AddLast("Oh");
        l.AddLast("My");
        l.AddLast("Delicious");
        l.AddLast("Bananas");
        l.AddLast("!!!");

        //ACT
        var uut = l.Contains("Apple");

        uut.Should().BeFalse();
    }
}
