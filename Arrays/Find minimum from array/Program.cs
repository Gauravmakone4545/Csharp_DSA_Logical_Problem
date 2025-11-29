
class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 11, 21, 3, 22, 4 };
        int min = arr[0];

        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        Console.WriteLine($"min number is {min}");
    }
}