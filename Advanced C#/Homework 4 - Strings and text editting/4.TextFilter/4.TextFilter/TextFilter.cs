using System;
using System.Text;
using System.Collections.Generic;

namespace TextFilter
{
	class MainClass
	{
		public static void Main (string[] args)
		{				
			int index = 0;
			StringBuilder censoredOutput = new StringBuilder ();
			Dictionary<string, List<int>> banWordOccurrances = new Dictionary<string, List<int>> ();

			string[] banList = Console.ReadLine ().Split (new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
			string text = Console.ReadLine ();

			foreach (string banWord in banList) {
				int startIndex = 0;

				while (text.IndexOf (banWord, startIndex) != -1) {
					if (text.Contains(banWord)) {
						if (banWordOccurrances.ContainsKey (banWord)) {
							banWordOccurrances [banWord].Add (text.IndexOf (banWord, startIndex));
						} else {
							banWordOccurrances.Add(banWord, new List<int>(){text.IndexOf (banWord, startIndex)});
						}

						startIndex = text.IndexOf (banWord, startIndex) + banWord.Length;
					} 
				}
			}
						
			censoredOutput.Append(text);
			foreach (var item in banWordOccurrances) {
				Console.WriteLine ("Ban word: {0} occurred at positions: {1}", item.Key, String.Join(", ", item.Value));

				foreach (var value in item.Value) {
					//Tried with appending. I was missing the last part of the text.
					//censoredOutput.Append  (text.Substring (index, value - index).PadRight (value - index + item.Key.Length, '*'));
					//index = value + item.Key.Length;
					for (int i = value; i < value + item.Key.Length; i++) {
						censoredOutput [i] = '*';
					}
				}
			}


			Console.WriteLine (censoredOutput);
		}
	}
}
