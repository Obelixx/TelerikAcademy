using System;
using System.Diagnostics;
using System.Linq;

public class AssertionsHomework
{
    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Error: arr not initialized in SelectionSort!");

        for (int index = 0; index < arr.Length - 1; index++)
        {
            Debug.Assert(arr[index] != null, "Error: arr value not initialized in SelectionSort!");
            Debug.Assert(arr.Length >= 2, "Error: No need to sort array with 1 or zero elements in SelectionSort!");
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Error: 'arr' not initialized in (public)BinarySearch!");
        Debug.Assert(value != null, "Error: 'value' not initialized in (public)BinarySearch!");
        Debug.Assert(arr.Any(el => arr.Skip(arr.ToList().IndexOf(el)).Any(bigElements => bigElements.CompareTo(el) >= 0)), "arr not sorted or sorted bad in (public)BinarySearch!");
        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    public static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        Console.WriteLine("Testing sorting of empty array and array with single element..");
        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array
        Console.WriteLine(".. done!");

        Console.WriteLine("Searching '-1000' :" + BinarySearch(arr, -1000));
        Console.WriteLine("Searching '0' :" + BinarySearch(arr, 0));
        Console.WriteLine("Searching '17' :" + BinarySearch(arr, 17));
        Console.WriteLine("Searching '10' :" + BinarySearch(arr, 10));
        Console.WriteLine("Searching '1000' :" + BinarySearch(arr, 1000));

        Debug.Assert(false, "Some asserts are throwing sometimes, but this homework is not for fixing the code!"); // Because this will be not included in 'Release' state!
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Error: 'arr' not initialized in FindMinElementIndex!");
        Debug.Assert(startIndex != endIndex, "Error: 'startIndex' is the same as endIndex in FindMinElementIndex!!");
        Debug.Assert(startIndex < endIndex, "Error: 'startIndex' must be before endIndex in FindMinElementIndex!!");
        Debug.Assert(startIndex >= 0, "Error: Bad 'startIndex' <=0; in FindMinElementIndex!");
        Debug.Assert(endIndex >= 0, "Error: Bad 'endIndex' <=0; in FindMinElementIndex!");
        Debug.Assert(startIndex <= arr.Length, "Error: Bad 'startIndex' > arr.Length; in FindMinElementIndex!");
        Debug.Assert(endIndex <= arr.Length, "Error: Bad 'endIndex' > arr.Length; in FindMinElementIndex!");

        int minElementIndex = startIndex;
        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        Debug.Assert(arr.Skip(startIndex).Take(endIndex - startIndex + 1).Any(el => arr[minElementIndex].CompareTo(el) >= 0), "Error: Bad 'min' element found in FindMinElementIndex!");
        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        Debug.Assert(!object.ReferenceEquals(x, y), "Error: You are swapping same elements in Swap!");
        Debug.Assert(!object.Equals(x, y), "Warning: You are swapping elements with same value in Swap! 'x'=" + x + " 'y'=" + y); // This is throwing sometimes, but this homework is not for fixing code!
        T oldX = x;
        x = y;
        y = oldX;
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(arr != null, "Error: 'arr' not initialized in BinarySearch!");
        Debug.Assert(value != null, "Error: 'value' not initialized in BinarySearch!");
        Debug.Assert(startIndex != endIndex, "Error: 'startIndex' is the same as endIndex in BinarySearch!!");
        Debug.Assert(startIndex < endIndex, "Error: 'startIndex' must be before endIndex in BinarySearch!!");
        Debug.Assert(startIndex >= 0, "Error: Bad 'startIndex' <=0; in BinarySearch!");
        Debug.Assert(endIndex >= 0, "Error: Bad 'endIndex' <=0; in BinarySearch!");
        Debug.Assert(startIndex <= arr.Length, "Error: Bad 'startIndex' > arr.Length; in BinarySearch!");
        Debug.Assert(endIndex <= arr.Length, "Error: Bad 'endIndex' > arr.Length; in BinarySearch!");
        Debug.Assert(arr.Any(el => arr.Skip(arr.ToList().IndexOf(el)).Any(bigElements => bigElements.CompareTo(el) >= 0)), "arr not sorted or sorted bad in BinarySearch!");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;
            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        Debug.Assert(arr.Any(el => !el.Equals(value)), "Element not found, but exist in BinarySearch!");
        //// Searched value not found
        return -1;
    }
}
