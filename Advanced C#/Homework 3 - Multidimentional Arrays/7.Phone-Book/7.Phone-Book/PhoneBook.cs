using System;
using System.Collections.Generic;

namespace PhoneBook
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string userInput = String.Empty;
			Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>> ();
			List<string> searchResults = new List<string> ();

			while (userInput != "search") {
				userInput = Console.ReadLine ();
				if (userInput.IndexOf ("-") != -1) {
					string name = userInput.Substring(0, userInput.IndexOf ("-"));
					string phoneNumber = userInput.Substring(userInput.IndexOf ("-") + 1);
					if (phonebook.ContainsKey (name)) {
						phonebook [name].Add (phoneNumber);
					} else {
						phonebook.Add (name, new List<string>(){phoneNumber});
					}
				}
			}

			while(userInput != "exit") {
				bool noMatchFound = true;
				userInput = Console.ReadLine ();
				foreach (KeyValuePair<string, List<string>> contact in phonebook) {
					if (contact.Key == userInput) {
						searchResults.Add (String.Format ("{0} -> {1}", contact.Key, String.Join(", ", contact.Value)));
						noMatchFound = false;
					}
				}
				if (userInput != "exit" && noMatchFound) {
					searchResults.Add (String.Format ("Contact {0} doesn't exist.", userInput));
					noMatchFound = true;
				}
			}
			foreach (var item in searchResults) {
				Console.WriteLine (item);
			}
		}
	}
}
