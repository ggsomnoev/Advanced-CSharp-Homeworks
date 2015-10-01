using System;
using System.Collections.Generic;

namespace PrimeFactor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long number = long.Parse (Console.ReadLine ());
			long finalNum = number;			
			long nextFactor = 2;
			List<long> factors = new List<long> ();

			while (number > 1) {
				if (number % nextFactor > 0) {
					nextFactor = 3;
					do {
						if (number % nextFactor == 0) {
							break;
						}

						nextFactor += 2;
					} while (nextFactor < number);
				}

				number /= nextFactor;
				factors.Add (nextFactor);
			}

			Console.WriteLine ("{0} = {1}", finalNum, String.Join(" * ", factors));
		}
	}
}
