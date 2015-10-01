using System;
using System.Collections.Generic;

namespace MatrixShuffling
{
	class MainClass
	{
		public static void Main ()
		{   
			int rowNum = int.Parse (Console.ReadLine ());
			int colNum = int.Parse (Console.ReadLine ());
			string[,] matrix = new string[rowNum, colNum];

			for (int i = 0; i < rowNum; i++) {
				for (int j = 0; j < colNum; j++) {
					matrix [i, j] = Console.ReadLine ();
				}
			}
			// swaping the values
			SwapValues (matrix);
		}

		public static void SwapValues(string[,] matrix) {
			string userInput = String.Empty;
			List<string> valuesToSwap = new List<string> ();
			while (userInput != "END") {
				userInput = Console.ReadLine ();
				valuesToSwap.Add (userInput);
			}

			// removing the "END" from the list
			valuesToSwap.RemoveAt (valuesToSwap.Count - 1);

			for (int i = 0; i < valuesToSwap.Count; i++) {
				string[] elements = valuesToSwap [i].Split (new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				if (elements [0] == "swap") {
					int xOne = int.Parse (elements [1]);
					int yOne = int.Parse (elements [2]);
					int xTwo = int.Parse (elements [3]);
					int yTwo = int.Parse (elements [4]);

					if (xOne < matrix.GetLength (0) && yOne < matrix.GetLength (1)
						&& xTwo < matrix.GetLength (0) && yTwo < matrix.GetLength (1)) {
						string temp = matrix [xOne, yOne];
						matrix [xOne, yOne] = matrix [xTwo, yTwo];
						matrix [xTwo, yTwo] = temp;

						Console.WriteLine ("(after swaping {1} and {0}:)", 
						                   matrix [xOne, yOne],
						                   matrix [xTwo, yTwo]);
						for (int k = 0; k < matrix.GetLength(0); k++) {
							for (int j = 0; j < matrix.GetLength(1); j++) {
								Console.Write ("{0} ", matrix [k, j]);
							}
							Console.WriteLine ();
						}
					} else {
						Console.WriteLine ("Invalid input!");
					}
				} else {
					Console.WriteLine ("Invalid input!");
				}
			}
		}
	}
}
