using System.Collections;

namespace PracticesAndSolutions.Leetcode;

//https://leetcode.com/problems/design-linked-list/description/

//Singly Linked list solution
public class MyLinkedList : IEnumerable<int>
{

    public Node Head;
    public int size;

    public int Get(int index)
    {
        if (index > size)
            return -1;

        var node = this.Head;
        while (node != null && index > 0)
        {
            node = node.Next;
            index--;
        }

        if (node == null)
            return -1;

        return node.Value;
    }

    public void AddAtHead(int val)
    {
        var newNode = new Node(val);
        newNode.Next = this.Head;
        this.Head = newNode;

        size++;
    }

    public void AddAtTail(int val)
    {
        if (Head == null)
        {
            this.AddAtHead(val);
            return;
        }
        else
        {
            var newNode = new Node(val);
            Node curr = Head;
            while (curr != null && curr.Next != null)//im stopping before last node
                curr = curr.Next;

            curr.Next = newNode;

            size++;
        }
    }

    public void AddAtIndex(int index, int val)
    {
        if (index > size) return;

        if (index == 0)
        {
            this.AddAtHead(val);
            return;
        }

        Node newNode = new Node(val);
        Node tempNode = Head;

        for (int i = 0; i < index - 1; i++)
            tempNode = tempNode.Next;

        newNode.Next = tempNode.Next;
        tempNode.Next = newNode;

        size++;
    }

    public void DeleteAtIndex(int index)
    {
        if (Head == null || index >= size
            || size == 0)
            return;

        if (index == 0)
            Head = Head.Next;

        if (Head == null)
            return;

        Node tempNode = Head;
        for (int i = 0; i < index - 1; i++)
        {
            tempNode = tempNode.Next;
        }

        if (tempNode.Next != null)
            tempNode.Next = tempNode.Next.Next;

        this.size--;
    }

    public IEnumerator<int> GetEnumerator()
    {
        var node = this.Head;
        while (node != null)
        {
            yield return node.Value;
            node = node.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();

}

public class Node
{
    public int Value;
    public Node? Next;

    public Node(int value)
    {
        Value = value;
    }
}



//-------------List solution
//public class DesignSinglyLinkedList
//{
//    private readonly List<int> _list = [];

//    public int Get(int index)
//    {
//        if (index < 0 || index >= _list.Count) return -1;

//        return _list[index];
//    }

//    public void AddAtHead(int val)
//    {
//        _list.Insert(0, val);
//    }

//    public void AddAtTail(int val)
//    {
//        _list.Add(val);
//    }

//    public void AddAtIndex(int index, int val)
//    {
//        if (index < 0 || index > _list.Count) return;

//        _list.Insert(index, val);
//    }

//    public void DeleteAtIndex(int index)
//    {
//        if (index < 0 || index >= _list.Count) return;

//        _list.RemoveAt(index);
//    }
//}
