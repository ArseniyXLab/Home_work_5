using System;

namespace ConsoleApp14
{
    class Program
    {
		private static void BubbleSort(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
				for (int j = 0; j < array.Length - 1; j++)
				if (array[j] > array[j + 1])
				{
				 int t = array[j + 1];
				array[j + 1] = array[j];
				array[j] = t;
				}
		}
		public static void Main()
		{
			Console.WriteLine("Сортировка Пузырьком");

			int [] array = { 5, 3, 4, 9, 7, 2, 8, 6 };
				BubbleSort(array);
			    foreach (int g in array)

			Console.WriteLine(g);

			Console.WriteLine("Сортировка Пирамидой");

			PyramidSort(array);
			    foreach (var e in array)

				Console.WriteLine(e);

			    Console.ReadKey();
		}

	static void PyramidSort(int[] array, int start, int end)
		{
			if (end == start) return;
			var pivot = array[end];
			var storeIndex = start;
			for (int i = start; i <= end - 1; i++)
				if (array[i] <= pivot)
				{
					var t = array[i];
					array[i] = array[storeIndex];
					array[storeIndex] = t;
					storeIndex++;
				}

			var n = array[storeIndex];
			array[storeIndex] = array[end];
			array[end] = n;
			if (storeIndex > start) PyramidSort(array, start, storeIndex - 1);
			if (storeIndex < end) PyramidSort(array, storeIndex + 1, end);
		}
		static void PyramidSort(int[] array)
		{
			PyramidSort(array, 0, array.Length - 1);
		}

		static Random random = new Random();

	}
}
