using System.Collections;

namespace BasicStructurePractices;

public class SimpleLinkedList<T> : IEnumerable<T>
{
    public sealed class Node<TT>
    {
        public readonly TT? _value;
        public Node<TT>? _next;

        public Node(TT? data, Node<TT>? next)
        {
            this._value = data;
            this._next = next;
        }
    }

    public int Count => _size;

    protected Node<T>? _head;
    protected Node<T>? _tail;
    private int _size;

    public bool IsEmpty => _tail is null && _head is null;

    public T? this[int index] => ItemAt(index);

    public SimpleLinkedList()
    {
        this._size = 0;
        this._tail = this._head = null;
    }

    public T? ItemAt(int index)
    {
        if (IsEmpty
            || index > this._size)
            throw new ArgumentOutOfRangeException($"Invalid value {index} index");

        var elementIdx = 0;
        var locatedNode = this._head;
        while (index != elementIdx
            && locatedNode is not null)
        {
            locatedNode = locatedNode._next;
            elementIdx++;
        }

        return locatedNode is null
            ? default : locatedNode!._value;
    }

    public int Add(T? item)
    {
        if (IsEmpty)
        {
            this._head = this._tail = new Node<T>(item, null);
        }
        else
        {
            var newNode = new Node<T>(item, null);
            this._tail!._next = newNode;
            this._tail = newNode;
        }

        this._size++;

        return this.Count;
    }

    public void AddFirst(T? item)
    {
        var node = new Node<T>(item, _head);
        this._head = node;

        if (IsEmpty)
            _tail = _head;

        this._size++;
    }

    public T? Remove(T item)
    {
        var prevNode = _head;

        T? res = default;

        if (_head is null)
            return res;

        SimpleLinkedList<T>.Node<T>? node;
        if (this._head._value?.Equals(item) is true)
        {
            this._head = this._head._next;
        }
        else
        {
            node = this._head._next;
            while (node is not null && (node._value?.Equals(item) is false))
            {
                prevNode = node;
                node = node!._next;
            }

            if (node is null)
                throw new InvalidOperationException($"Cannot find item {item}");

            prevNode!._next = node._next;
            res = node._value;
        }

        this._size--;

        return res;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var node = this._head;
        while (node is not null)
        {
            var avalue = node._value;
            node = node._next;
            yield return avalue!;
        }
    }

    IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
}
