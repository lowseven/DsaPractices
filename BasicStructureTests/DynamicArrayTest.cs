using BasicStructurePractices;
using FluentAssertions;

namespace BasicStructureTests;

[TestClass]
public class DynamicArrayTest
{
    [TestMethod]
    public void DynamicArray_Should_Init_Array()
    {
        //ARRANGE
        var capacity = 20;

        //ACT
        var uut = new DynamicArray<string>(capacity);

        //ASSERT
        uut.Capacity.Should().Be(capacity);
        uut.Size.Should().Be(0);
        uut.IsEmpty.Should().BeTrue();
    }

    [TestMethod]
    public void DynamicArray_Add_Should_Be_Able_To_Add_Items()
    {
        //ARRANGE, ACT
        var uut = new DynamicArray<string>
        {
            "Hello",
            "World",
            "!!"
        };

        //ASSERT
        uut.Capacity.Should().Be(16);
        uut.Size.Should().Be(3);
        uut[0].Should().Be("Hello");
        uut[1].Should().Be("World");
        uut[2].Should().Be("!!");
    }

    [TestMethod]
    public void DynamicArray_Add_Should_Be_Able_To_Resize_MaximmumCapacity()
    {
        //ARRANGE, ACT
        var uut = new DynamicArray<string>(2)
        {
            "Hello",
            "World",
            "!!",
            "!!"
        };

        //ASSERT
        uut.Capacity.Should().Be(8);
        uut.Size.Should().Be(4);
        uut[0].Should().Be("Hello");
        uut[1].Should().Be("World");
        uut[2].Should().Be("!!");
        uut[3].Should().Be("!!");
    }

    [TestMethod]
    public void DynamicArray_RemoveAt_Should_Remove_Item_At_index()
    {
        //ARRANGE
        var uut = new DynamicArray<string>(2)
        {
            "Hello",
            "World",
            "!!",
            "!!"
        };

        //ACT
        var removedItem = uut.RemoveAt(1);

        //ASSERT
        uut.Capacity.Should().Be(7);
        uut.Size.Should().Be(3);
        uut[0].Should().Be("Hello");
        uut[1].Should().Be("!!");
        uut[2].Should().Be("!!");

        removedItem.Should().Be("World");
    }

    [TestMethod]
    public void DynamicArray_Remove_Should_Remove_Item_At_index()
    {
        //ARRANGE
        var uut = new DynamicArray<string>(2)
        {
            "Hello",
            "World",
            "!!",
            "!!"
        };

        //ACT
        var removedItem = uut.Remove("!!");

        //ASSERT
        uut.Capacity.Should().Be(7);
        uut.Size.Should().Be(3);
        uut[0].Should().Be("Hello");
        uut[1].Should().Be("World");
        uut[2].Should().Be("!!");

        removedItem.Should().Be("!!");
    }

    [TestMethod]
    public void DynamicArray_Enumerator_Should_Be_Iterable()
    {
        //ARRANGE
        var uut = new DynamicArray<string>(2)
        {
            "Hello",
            "World",
            "!!",
            "!!"
        };

        //ACT, ASSERT
        uut.SequenceEqual(new[] { "Hello", "World", "!!", "!!" }).Should().BeTrue();
    }

    [TestMethod]
    public void DynamicArray_ToString_Should_Be_List_All_Item_Into_A_FormattedString()
    {
        //ARRANGE
        var expectedVal = $"[{string.Join(", ", new[] { "Hello", "World", "!!", "!!" }).Trim()}]";

        //ACT
        var uut = new DynamicArray<string>(2)
        {
            "Hello",
            "World",
            "!!",
            "!!"
        };

        //ACT
        expectedVal.ToString().Should().Be(uut.ToString());
    }
}