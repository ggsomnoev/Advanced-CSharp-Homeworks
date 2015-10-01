using System;

namespace MatrixSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] userInp = Console.ReadLine ().Split (new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			int rowNums = int.Parse (userInp [0]);
			int colNums = int.Parse (userInp [1]);
			int[,] matrix = new int[rowNums, colNums];

			for (int i = 0; i < rowNums; i++) {
				userInp = Console.ReadLine ().Split (new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < colNums; j++) {
					matrix [i, j] = int.Parse (userInp [j]);
				}
			}

			FindingBestSum (matrix);
		}
		public static void FindingBestSum(int[,] matrix) {
			int sum = 0, x = 0, y = 0, bestSum = 0;

			for (int i = 0; i < matrix.GetLength(0) - 2; i++) {
				for (int j = 0; j < matrix.GetLength(1) - 2; j++) {
					sum = matrix [i, j] + matrix [i, j + 1] + matrix [i, j + 2]
					+ matrix [i + 1, j] + matrix [i + 1, j + 1] + matrix [i + 1, j + 2]
					+ matrix [i + 2, j] + matrix [i + 2, j + 1] + matrix [i + 2, j + 2];

					if (sum > bestSum) {
						bestSum = sum;
						x = i;
						y = j;
					}
				}
			}
			Console.WriteLine ("\nBest sum = {0}", bestSum);
			for (int i = x; i < 4; i++) {
				for (int j = y; j < 4; j++) {
					Console.Write ("{0, 2}", matrix [i, j]);
				}
				Console.WriteLine ();
			}
		}
	}
}
