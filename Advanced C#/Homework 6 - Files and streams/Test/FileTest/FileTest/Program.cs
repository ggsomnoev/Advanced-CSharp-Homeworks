using System;
using System.IO;
using System.Text;
using FileTest;
using System.Collections.Generic;
using System.Linq;

namespace FileTest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] text = Console.ReadLine().Split(new char[] { ' ', '.', '!', '?',',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
			List<string> rezult = new List<String>();
			for (int i = 0; i < text.Length; i++)
			{
				bool palindrome = true;
				for (int j = 0; j < ((text[i].Length + 1) / 2); j++) 
				{
					if (text[i][j] != text[i][text[i].Length - j - 1])
					{
						palindrome = false;
					}
				}
				if (palindrome)
				{
					rezult.Add(text[i]);
				}
			}
			rezult.Sort();
			Console.WriteLine(string.Join(", ", rezult));
		}
	}
}
