using System;

class ReverseArray
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int start = 0;
        int end = arr.Length - 1;

        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;

            start++;
            end--;
        }

        Console.WriteLine("Reversed Array: " + string.Join(", ", arr));
    }
}
