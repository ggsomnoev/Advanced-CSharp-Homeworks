using System;
using System.Collections.Generic;

namespace HashsetTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{	List<int> ads = new List<int> ();

			ads.Add (1);
			ads.Add (3);
			ads.Add (123);
			ads.Add (3);
			ads.Add (1);
			Console.WriteLine (String.Join(" ",ads));
			Dictionary<int, int> dict = new Dictionary<int, int> ();
			foreach (KeyValuePair<int, int> item in dict) {
				Console.WriteLine (item.Key);
			}
		}
	}
}
