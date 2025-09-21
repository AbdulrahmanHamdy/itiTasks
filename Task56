using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI
{
class Task56
{
    public static void Sort(int[] arr)
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
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) break;
        }
    }
    public static void Reverse(ArrayList list)
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
        foreach (var num in numbers)
        {
            if (num % 2 == 0)
                evens.Add(num);
        }
        return evens;
    }

    public static int FirstNonRepeatedCharIndex(string s)
    {
        Dictionary<char, int> freq = new Dictionary<char, int>();

        // Count frequencies
        foreach (char c in s)
        {
            if (freq.ContainsKey(c))
                freq[c]++;
            else
                freq[c] = 1;
        }

        // Find first unique
        for (int i = 0; i < s.Length; i++)
        {
            if (freq[s[i]] == 1)
                return i;
        }
        return -1;
    }




}
}
