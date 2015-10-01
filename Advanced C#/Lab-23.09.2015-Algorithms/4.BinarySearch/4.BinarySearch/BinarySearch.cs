using System;

namespace BinarySearch
{
	class MainClass
	{
		public static void Main ()
		{
			string[] userInputValues = Console.ReadLine ().Split (' ');
			int searchElem = int.Parse (Console.ReadLine ());
			int[] numbers = new int[userInputValues.Length];

			for (int i = 0; i < numbers.Length; i++) {
				numbers [i] = int.Parse (userInputValues [i]);
			}

			Console.WriteLine(BinarySearch (numbers, searchElem));
		}

		public static int LinearSearch (int[] nums, int element) {
			int index = - 1;
			for (int i = 0; i < nums.Length; i++) {
				if(nums[i] == element) {
					index = i;
					break;
				}
			}
			return index;
		}

		public static int BinarySearch (int[] nums, int element) {
			int index = -1;
			int startIndex = 0;
			int endIndex = nums.Length;

			while (startIndex <= endIndex) {
				int midPoint = (startIndex + endIndex) / 2;

				if (nums [midPoint] < element) {
					startIndex = midPoint + 1;
				} else if (nums [midPoint] > element) {
					endIndex = midPoint - 1;
				} else {
					index = midPoint;
					break;
				}
			}
			return index;
		}
	}
}
// 1 3 5 7 11 13 17 19 23 29 31 37 41 43 47 53 59
// 37
