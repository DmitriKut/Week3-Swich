using System;

namespace PersonalityTestSwitch
{
	class Program
	{
		static void Main(string[] args)
		{
			//programm küsib kasutajalt sisestada tema lemmikvärv;
			//kui kasutaja sisestab "punane", konsool kuvab "oled romantiline";
			//kui kasutaja sisestab "sinine", konsool kuvab "oled töökas";
			//kui kasutaja sisestab "roheline", konsole kuvab "oled looduse sõber";
			// kui kasutaja sisestab midagi muud, kobsool kuvab "oled {userColor} ükssarvik";

			Console.WriteLine("Sisesta oma lemmikvärvi:");
			string userColor = Console.ReadLine().ToLower();

			switch (userColor)
			{
				case "punane": //if(userColor == "punane")
					Console.WriteLine("Oled romantiline.");
					break;
				case "sinine":
					Console.WriteLine("Oled töökas.");
					break;
				case "roheline":
					Console.WriteLine("Oled looduse sõber.");
					break;
				default:
					Console.WriteLine($"Oled {userColor} ükssarvik.");
					break;
			}

			Console.WriteLine("Kena päeva!");
		}
	}
}
