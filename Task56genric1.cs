namespace ITI
{
    class Task56genric1
    {
       class Range<T> where T : IComparable<T>
         {
    public T Min { get; }
    public T Max { get; }

    public Range(T min, T max)
    {
        if (min.CompareTo(max) > 0)
            throw new ArgumentException("Min cannot be greater than Max.");

        Min = min;
        Max = max;
    }

    public bool IsInRange(T value)
    {
        return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
    }

    public dynamic Length()
    {
        
        return (dynamic)Max - (dynamic)Min;
    }
}

    }


    }
