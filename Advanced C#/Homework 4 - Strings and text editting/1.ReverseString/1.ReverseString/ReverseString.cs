using System;
using System.Text;

namespace ReverseString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string userInput = Console.ReadLine ();
			ReverseString (userInput);
		}

		public static void ReverseString(string input) {
			StringBuilder reversedStr = new StringBuilder ();
			for (int i = input.Length - 1; i >= 0; i--) {
				reversedStr.Append(input[i]);
			}
			Console.WriteLine (reversedStr);
		}
	}
}
