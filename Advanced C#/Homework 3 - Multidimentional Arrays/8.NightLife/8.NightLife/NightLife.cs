using System;
using System.Collections.Generic;

namespace NightLife
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Dictionary<string, SortedDictionary<string, SortedSet<string>>> performances = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

			string input = Console.ReadLine();

			while (input != "END")
			{
				string[] nightClubsInfo = input.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
				string city = nightClubsInfo[0];
				string clubName = nightClubsInfo[1];
				string performer = nightClubsInfo[2];

				if (!performances.ContainsKey(city))
				{
					performances[city] = new SortedDictionary<string, SortedSet<string>>();
				}
				if (!performances[city].ContainsKey(clubName))
				{
					performances[city][clubName] = new SortedSet<string>();
				}
				if (!performances[city][clubName].Contains(performer))
				{
					performances[city][clubName].Add(performer);
				}

				input = Console.ReadLine();
			}

			foreach (var cityVenue in performances)
			{
				Console.WriteLine("{0}", cityVenue.Key);

				foreach (var venueWithPerformers in cityVenue.Value)
				{
					Console.WriteLine("->{0}: {1}", venueWithPerformers.Key, string.Join(", ", venueWithPerformers.Value));
				}
			}
		}
	}
}
