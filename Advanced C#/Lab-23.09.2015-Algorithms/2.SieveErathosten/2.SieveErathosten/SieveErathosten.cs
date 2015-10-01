using System;
using System.Collections.Generic;

namespace SieveErathosten
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			
			int size = int.Parse(Console.ReadLine());
			bool[] boolArray = new bool[size];
			List<int> primeNum = new List<int> ();

			for (int i = 2; i < boolArray.GetLength(0); i++) 
			{
				boolArray [i] = true;
			}

			for (int a = 2; a < boolArray.GetLength(0); a++) 
			{
				if (boolArray [a]) 
				{
					for (int b = 2*a; b < boolArray.GetLength(0); b +=a) 
					{
						boolArray [b] = false;
					}
				}
			}

			for (int i = 0; i < boolArray.GetLength(0); i++) 
			{
				if (boolArray [i]) 
				{
					primeNum.Add (i);
				}
			}

			Console.WriteLine(String.Join(", ", primeNum));
		}
	}
}
