using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicStructurePractices;

public class LinkedListQueue<T>
{
    private readonly LinkedList<T> _linkedList = new();

    public int Count => _linkedList.Count;
    public bool IsEmpty => _linkedList.Any() is false;

    public LinkedListQueue()
    {

    }

    public LinkedListQueue(T item)
    {
        Enqueue(item);
    }

    public void Enqueue(T Item)
    {
        _linkedList.AddLast(Item);
    }

    //Poll an element from the fron of the queueu
    //the mthod throws an error if the queue is empty
    public T? Dequeue()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue is empty");

        var data = _linkedList.First;
        _linkedList.RemoveFirst();

        return data.Value;
    }

    //Peek the element at the front of the queue
    //the method throws an error if the queue is empty
    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException("Queue is empty");

        return _linkedList.First!.Value;
    }

}
