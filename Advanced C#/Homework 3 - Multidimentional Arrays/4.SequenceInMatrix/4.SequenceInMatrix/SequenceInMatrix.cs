using System;

namespace SequenceInMatrix
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int bestCount = 1;
			int[] bestIndex = new int[2] {0, 0};

			int rowNums = int.Parse (Console.ReadLine ());
			int colNums = int.Parse (Console.ReadLine ());

			string[,] matrix = new string[rowNums, colNums];

			for (int i = 0; i < matrix.GetLength(0); i++) {
				string[] row = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < matrix.GetLength(1); j++) {
					matrix [i, j] = row [j];
				}
			}

			for (int i = 0; i < matrix.GetLength(0); i++) {
				for (int j = 0; j < matrix.GetLength(1); j++) {
					int count = CheckForEquality (matrix, i, j);
					if (count > bestCount) {
						bestCount = count;
						bestIndex [0] = i;
						bestIndex [1] = j;
					}
				}
			}

			PrintSeq (matrix, bestIndex [0], bestIndex [1], bestCount);
		}

		public static int CheckForEquality(string[,] matrix, int x, int y) {
			int rowResult = CheckRow (matrix, x, y);
			int colResult = CheckCol (matrix, x, y);
			int diagResult = CheckDiag (matrix, x, y);

			return Math.Max (Math.Max (rowResult, colResult), diagResult);
		}

		public static int CheckRow(string[,] matrix, int x, int y) {
			int count = 1;

			for (int j = y + 1; j < matrix.GetLength(1); j++) {
				if (matrix [x, y] == matrix [x, j]) {
					count++;
				} else {
					count = 1;
					break;
				}
			}

			return count;
		}

		public static int CheckCol(string[,] matrix, int x, int y) {
			int count = 1;

			for (int j = x + 1; j < matrix.GetLength(0); j++) {
				if (matrix [x, y] == matrix [j, y]) {
					count++;
				} else {
					count = 1;
					break;
				}
			}

			return count;
		}

		public static int CheckDiag(string[,] matrix, int x, int y) {
			int count = 1;
			int length = Math.Min (matrix.GetLength (0) - x, matrix.GetLength (1) - y);

			for (int i = 1; i < length; i++) {
				if (matrix [x, y] == matrix [x + i, y + i]) {
					count++;
				} else {
					count = 1;
					break;
				}
			}

			return count;
		}

		public static void PrintSeq(string[,] matrix, int x, int y, int Length) {
			for (int i = 0; i < Length; i++) {
				Console.Write ("{0} ", matrix [x, y]);
			}	
		}
	}
}
