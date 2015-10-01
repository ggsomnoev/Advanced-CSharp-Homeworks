using System;

namespace CountSymbols
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] chars = Console.ReadLine ().ToCharArray ();
			int[] charVals = new int[Byte.MaxValue];

			for (int i = 0; i < chars.Length; i++) {
				charVals [(int)chars [i]]++;
			}
			for (int i = 0; i < charVals.Length; i++) {
				if (charVals [i] != 0) {
					Console.WriteLine ("{0}: {1} time/s", (char)i, charVals [i]);
				}
			}
		}
	}
}
