using System;

namespace StringLength
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string userInput = Console.ReadLine ();
			if (userInput.Length <= 20) {
				Console.WriteLine (userInput.PadRight (20, '*'));
			} else {
				Console.WriteLine (userInput.Substring (0, 20));
			}
		}
	}
}
