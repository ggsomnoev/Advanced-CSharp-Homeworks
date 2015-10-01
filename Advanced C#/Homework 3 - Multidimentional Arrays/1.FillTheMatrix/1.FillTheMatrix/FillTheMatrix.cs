using System;

namespace FillTheMatrix
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int rowNum = int.Parse (Console.ReadLine ());
			int colNum = int.Parse (Console.ReadLine ());

			int[,] matrix = new int[rowNum,colNum];

			InitMatrixPatrOne (matrix);
			Console.WriteLine ();
			InitMatrixPatrTwo (matrix);
		}

		public static void InitMatrixPatrOne(int[,] matrix) {
			int value = 1;
			for (int row = 0; row < matrix.GetLength(0); row++) {
				for (int col = 0; col < matrix.GetLength(1); col++) {
					matrix [col, row] = value;
					value++;
				}
			}

			for (int row = 0; row < matrix.GetLength(0); row++) {
				for (int col = 0; col < matrix.GetLength(1); col++) {
					Console.Write("{0,3}", matrix [row, col]);
				}
				Console.WriteLine ();
			}
		}

		public static void InitMatrixPatrTwo(int[,] matrix) {
			int value = 1;
			int temp = 1;
			for (int row = 0; row < matrix.GetLength(0); row++) {
				if (temp % 2 != 0) { 
					for (int col = 0; col < matrix.GetLength(1); col++) {
						matrix [col, row] = value;
						value++;
					}
					temp++;
				} else {
					for (int col = matrix.GetLength(1) - 1; col >= 0; col--) {
						matrix [col, row] = value;
						value++;
					}
					temp++;
				}
			}

			for (int row = 0; row < matrix.GetLength(0); row++) {
				for (int col = 0; col < matrix.GetLength(1); col++) {
					Console.Write("{0,3}", matrix [row, col]);
				}
				Console.WriteLine ();
			}
		}
	}
}
