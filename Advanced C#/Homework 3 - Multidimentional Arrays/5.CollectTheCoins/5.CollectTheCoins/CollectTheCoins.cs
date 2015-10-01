using System;

namespace CollectTheCoins
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[][] matrix = new char[4][];
			//init the jagged array
			for (int i = 0; i < 4; i++) {
				char[] row = Console.ReadLine ().ToCharArray();
				matrix[i] = new char [row.Length];
				for (int j = 0; j < row.Length; j++) {
					matrix [i] [j] = row [j];
				}
			}
			//getting the list of directions
			char[] commands = Console.ReadLine().ToCharArray();

			CountCoinsAndWallHits (matrix, commands);
		}

		public static void CountCoinsAndWallHits(char[][] matrix, char[] commands) {
			int wallHits = 0, coinsCollected = 0;
			int[] initialIndexes = new int[2] { 0, 0 };
			for (int i = 0; i < commands.Length; i++) {
				int[] command = GiveDirection(commands [i]);
				if ((initialIndexes [0] + command [0] >= matrix.GetLength(0) - 1) || 
				    (initialIndexes [1] + command [1] >= matrix[initialIndexes [0]].Length) ||
				    (initialIndexes [0] + command [0] < 0) || 
					(initialIndexes [1] + command [1] < 0)) {
					wallHits++;
					Console.WriteLine ("index[{0}][{1}] -> Wall", initialIndexes [0], initialIndexes [1]);
				} else {
					initialIndexes [0] += command [0];
					initialIndexes [1] += command [1];
					Console.Write ("index[{0}][{1}]", initialIndexes [0], initialIndexes [1]);
					if (matrix [initialIndexes [0]] [initialIndexes [1]] == '$') {
						coinsCollected++;
						Console.Write (" -> Coin\n");
					} else {
						Console.Write ("\n");
					}
				}
			}
			Console.WriteLine ("Coins collected:{0}\nWalls hit:{1}", coinsCollected, wallHits);
		}

		public static int[] GiveDirection(char dir) {
			switch (dir) {
			case '>':
				return new int[2]{0, 1};
			case '^':
				return new int[2]{-1, 0};
			case '<':
				return new int[2]{0, -1};
			case 'V':
				return new int[2]{1, 0};
			default:
				Console.WriteLine ("Error occured in the switch statement");
				return new int[2]{0, 0};
			}
		}
	}
}
