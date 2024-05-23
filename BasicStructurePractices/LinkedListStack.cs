namespace BasicStructurePractices;

public sealed class LinkedListStack<T> : LinkedList<T>
{
    public LinkedListStack()
    {
    }

    public LinkedListStack(T item)
    {
        AddFirst(item);
    }

    //push element on the stack
    public void Push(T item) =>
        AddFirst(item);

    //pop element off the stack
    //Throws an error is the stack is empty
    public T? Pop()
    {
        if (this.Any() is false)
            throw new InvalidOperationException("Empty list");
        
        var data = this.First();
        this.RemoveFirst();
    
        return data;
    }

    //Peek the top of the stack without removing an element 
    //throws an exception if the stack is empty
    public T? Peek()
    {
        if (this.Any() is false)
            throw new InvalidOperationException("Empty list");

        return this.First();
    }
}
