using System;
using System.Collections;
using System.Collections.Generic;


namespace ITI
  
class Task7
{
   
    public static void BubbleSortOptimized(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped)
                break;
        }
    }
    public class Range<T> where T : IComparable<T>
    {
        private T min;
        private T max;

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
                throw new ArgumentException("Minimum cannot be greater than Maximum");

            this.min = min;
            this.max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(min) >= 0 && value.CompareTo(max) <= 0;
        }

        public dynamic Length()
        {
            return (dynamic)max - (dynamic)min;
        }
    }


    public static void ReverseArrayList(ArrayList list)
    {
        int left = 0, right = list.Count - 1;
        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }

   
    public static List<int> GetEvenNumbers(List<int> numbers)
    {
        List<int> evens = new List<int>();
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
                evens.Add(num);
        }
        return evens;
    }

 
    public class FixedSizeList<T>
    {
        private T[] items;
        private int count = 0;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0) throw new ArgumentException("Capacity must be positive.");
            items = new T[capacity];
        }

        public void Add(T item)
        {
            if (count >= items.Length)
                throw new InvalidOperationException("List is full. Cannot add more elements.");
            items[count++] = item;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Invalid index.");
            return items[index];
        }
    }

  
    public static int FindFirstUnique(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (freq[s[i]] == 1)
                return i;
        }
        return -1;
    }

 
    static void Main()
    {
       
        int[] arr = { 5, 1, 4, 2, 8 };
        BubbleSortOptimized(arr);
        Console.WriteLine("Sorted: " + string.Join(", ", arr));

        
        Range<int> intRange = new Range<int>(10, 20);
        Console.WriteLine("Is 15 in range? " + intRange.IsInRange(15));
        Console.WriteLine("Range length: " + intRange.Length());

      
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
        ReverseArrayList(list);
        Console.WriteLine("Reversed ArrayList: " + string.Join(", ", list.ToArray()));

       
        List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6 };
        List<int> evens = GetEvenNumbers(nums);
        Console.WriteLine("Even numbers: " + string.Join(", ", evens));

        FixedSizeList<string> fixedList = new FixedSizeList<string>(2);
        fixedList.Add("Hello");
        fixedList.Add("World");
        Console.WriteLine("FixedSizeList[1] = " + fixedList.Get(1));

        r
        string str = "swiss";
        int index = FindFirstUnique(str);
        Console.WriteLine("First non-repeated char index: " + index);
    }
}
