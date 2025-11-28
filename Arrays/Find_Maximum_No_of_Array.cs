class Program
{
	static void Main(string[] args)
	{
		int[] arr = { 1, 2, 3, 4, 5, 99, 100, 10000, 1221 };

		int max = arr[0];

		for (int i = 1; i < arr.Length; i++)
		{
			if (arr[i] > max)
			{
				max = arr[i];
			}
		}

		//foreach (int num in arr)
		//{

		//    if (num > max)
		//    {
		//        max = num;
		//    }
		//}
		Console.WriteLine($"max number is   {max}");
	}
}

