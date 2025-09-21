namespace ITI
{
     class Task1
    {
        class FixedSizeList<T>
        {
    private T[] items;
    private int count = 0;

    public FixedSizeList(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than 0.");
        items = new T[capacity];
    }

    public void Add(T item)
    {
        if (count >= items.Length)
            throw new InvalidOperationException("List is full. Cannot add more items.");
        items[count++] = item;
    }

    public T Get(int index)
    {
        if (index < 0 || index >= count)
            throw new IndexOutOfRangeException("Invalid index.");
        return items[index];
    }

    public int Count => count;
    public int Capacity => items.Length;
}
    }


    }
