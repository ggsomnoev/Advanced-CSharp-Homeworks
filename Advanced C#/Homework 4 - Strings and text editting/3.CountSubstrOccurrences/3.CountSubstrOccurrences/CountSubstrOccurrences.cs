using System;

namespace CountSubstrOccurrences
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int start = 0, counter = 0;
			string userInput = Console.ReadLine ().ToLower();
			string searchingValue = Console.ReadLine ();

			int index = userInput.IndexOf (searchingValue, start);
			while (index!= -1) {
				counter++;
				Console.WriteLine ("Found at index: {0}", index);
				start = index + searchingValue.Length;
				index = userInput.IndexOf (searchingValue, start);
			}

			Console.WriteLine ("Input Length: {0}.\nThe word = \"{1}\" occurred {2} time/s",
			                   userInput.Length, searchingValue, counter);
		}
	}
}
