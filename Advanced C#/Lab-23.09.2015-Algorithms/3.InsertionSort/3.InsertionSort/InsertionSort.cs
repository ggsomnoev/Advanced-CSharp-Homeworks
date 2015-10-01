using System;
using System.Collections.Generic;

namespace InsertionSort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] elements = Console.ReadLine ().Split (' ');
			int[] numbers = new int[elements.Length];				


			for (int i = 0; i < elements.Length; i++) {
				numbers [i] = int.Parse (elements [i]);
			}

			SelectionSort (numbers);

			Console.WriteLine (String.Join (" ", numbers));
		}

		public static void SelectionSort(int[] nums) {
			for (int i = 1; i < nums.Length; i++) {
				int elem = nums [i];
				int j = i;
				while (j > 0 && nums[j - 1] > elem) {
					nums [j] = nums [j - 1];
					nums [j - 1] = elem;					
					j--;
				}
			}
		}
	}
}

