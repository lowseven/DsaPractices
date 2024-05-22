using System.Collections;

namespace BasicStructurePractices;

public sealed class DoubleLinkedList<T> : IEnumerable<T>
{
    private class Node<TT>
    {
        public TT? Data { get; set; }
        public Node<TT>? Next { get; set; }
        public Node<TT>? Prev { get; set; }

        public Node(TT Item, Node<TT>? next, Node<TT>? prev)
        {
            this.Next = next;
            this.Prev = prev;
            Data = Item;
        }
    }

    private Node<T>? _head;
    private Node<T>? _tail;

    public int Count { get; private set; }
    public bool IsEmpty => Count is 0;

    public void Add(T item) =>
        this.AddLast(item);


    public void Clear()
    {
        var node = _head;
        while (node is not null)
        {
            var trav = node.Next;

            node.Data = default;
            node.Prev = null;
            node.Next = null;

            node = trav;

        }

        _head = _tail = null;
        Count = 0;
    }

    public void AddLast(T item)
    {
        var newNode = new Node<T>(item, null, null);
        if (this._head is null && this._tail is null)
        {
            this._head = this._tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            newNode.Prev = this._tail;

            this._tail = newNode;
        }
        Count++;
    }

    public void AddFirst(T item)
    {
        var newNode = new Node<T>(item, null, null);

        if (_head is null)
        {
            _tail = _head = newNode;
        }
        else
        {
            newNode.Next = this._head;
            _head.Prev = newNode;

            _head = newNode;
        }

        Count++;
    }

    public T? PeekFirst()
    {
        if (this.IsEmpty)
            throw new InvalidOperationException("The list is empty");

        return this._head!.Data;
    }

    public T? PeekLast()
    {
        if (this.IsEmpty)
            throw new InvalidOperationException("The list is empty");

        return this._tail!.Data;
    }

    public T? RemoveFirst()
    {
        if (this.IsEmpty)
            throw new InvalidOperationException("The list is empty");

        var node = this._head;
        this._head = null;

        this._head = node!.Next;
        if (this._head is not null)
            this._head!.Prev = null;

        this.Count--;

        if (IsEmpty)//when removing the first element the list is empty set the tail as null...
            _tail = null;

        return node.Data;
    }

    public T? RemoveLast()
    {
        if (this.IsEmpty)
            throw new InvalidOperationException("The list is empty");

        var node = this._tail;
        this._tail = null;

        this._tail = node!.Prev;
        if (this._tail is not null)
            this._tail!.Next = null;

        this.Count--;

        if (IsEmpty)//when removing the first element the list is empty set the tail as null...
            _head = null;

        return node.Data;
    }

    //NOTE: remove a node from the linked list in O(1)
    private T? Remove(Node<T>? node)
    {
        if (node is null)
            return default;

        //is the head?
        if (node!.Prev is null)
            return RemoveFirst();
        //is the tail?
        if (node.Next is null)
            return RemoveLast();

        node.Next!.Prev = node.Prev;
        node.Prev!.Next = node.Next;

        var data = node.Data;

        node.Prev = node.Next = null;

        Count--;

        return data;
    }

    public T? Remove(T? item)
    {
        var node = this._head;
        while (node is not null
            && node?.Data?.Equals(item) is false)
        {
            node = node.Next;
        }

        return Remove(node);
    }

    public T? RemoveAt(int index)
    {
        if (index < 0
            || index >= Count) throw new ArgumentOutOfRangeException($"Index value {index} is out of range");

        var acc = 0;
        Node<T> node;
        //while (node is not null 
        //    && count <= index)
        //{
        //    node = node.Next;
        //    count++;
        //}

        //with small clever improvement
        if (Count / 2 >= index)
        {//search in the left side of the list 
            node = this._head;
            while (node is not null
                && acc != index)
            {
                node = node.Next;
                acc++;
            }
        }
        else
        {//is probably on the right side of the list 
            acc = Count - 1;
            node = this._tail;
            while (node is not null
                && acc != index)
            {
                node = node.Prev;
                acc--;
            }
        }

        return Remove(node);

    }

    public int IndexOf(T? item)
    {
        if (IsEmpty)
            return -1;

        var node = this._head;
        var acc = 0;
        while (node is not null
            && node.Data?.Equals(item) is false)
        {
            node = node.Next;
            acc++;
        }

        if(node is null)
            return -1;

        return acc;
    }

    public bool Contains(T? item) =>
        IndexOf(item) >= 0;

    public IEnumerator<T> GetEnumerator()
    {
        var node = _head;
        while (node is not null)
        {
            yield return node.Data!;
            node = node.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
