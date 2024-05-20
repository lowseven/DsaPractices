using System.Collections;

namespace BasicStructurePractices;

public sealed class DynamicArray<T> : IEnumerable<T>
{
    private T[] _array;

    public int Size { get; private set; } = 0;
    public int Capacity { get; private set; } = 0;
    public bool IsEmpty => Size == 0;

    public T this[int index] => index < Size ? _array[index]
        : throw new ArgumentOutOfRangeException($"index out of range {nameof(index)}");

    public DynamicArray() : this(16) { }

    public DynamicArray(int capacity)
    {
        if (capacity < 0 && Size < capacity)
            throw new ArgumentOutOfRangeException($"index out of range {nameof(capacity)}");

        this.Capacity = capacity;
        this._array = new T[capacity];
    }


    public void Add(T item)
    {
        if (this.Size + 1 >= this._array.Length)
        {
            this.Capacity *= 2;

            var newArray = new T[this.Capacity];
            this._array.CopyTo(newArray, 0);
            this._array = newArray;
        }

        this._array[this.Size++] = item;
    }


    public T RemoveAt(int index)
    {
        if (!(index >= 0 || Size >= index))
            throw new ArgumentOutOfRangeException($"index out of range{nameof(index)}");

        var newArray = new T[this.Capacity];
        var resVal = default(T);
        for (int i = 0, j = 0; i < this.Size; i++)
        {
            if (i != index)
            {
                newArray[j++] = this._array[i];
            }
            else
            {
                resVal = this._array[i];
            }
        }

        this._array = newArray;
        this.Size--;
        this.Capacity--;

        return resVal!;
    }

    public T Remove(T item)
    {
        if(item is null)
            throw new ArgumentNullException(nameof(item));

        var index = 0;
        foreach (var t in this._array)
        {
            if (t!.Equals(item))//using Object.Equals()..
                break;

            index++;
        }

        return RemoveAt(index);
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var item in this._array.Take(this.Size))
        {
            yield return item;
        }
    }

    public override string ToString() =>
        $"[{string.Join(", ", this).Trim()}]";

    IEnumerator IEnumerable.GetEnumerator() => this._array.GetEnumerator();
}
