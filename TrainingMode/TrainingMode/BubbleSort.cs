using System;
using System.Collections.Generic;
using System.Text;

namespace TrainingMode
{
    class BubbleSort
    {
        public static void bubbleSort(int[] intArray)
        {
			// int[] intArray = { 5, 10, 99, 1, 3 };

			// メソッド使用例
			// int[] intArray = { 5, 10, 99, 1, 3 };
			// BubbleSort.bubbleSort(intArray);

			for (int t = 0; t < intArray.Length; t++)
			{
				for (int n = (intArray.Length - 1); n > 0; n--)
				{
					if (intArray[n] < intArray[n - 1])
					{
						int tmp;
						tmp = intArray[n - 1];
						intArray[n - 1] = intArray[n];
						intArray[n] = tmp;
					}
				}
			}
			foreach (int i in intArray)
			{
				Console.Write(string.Join("", i));
			}

			Console.WriteLine(string.Join(",", intArray));
		}
    }
}
