using System;
using System.Collections.Generic;
//Kahveler listemizi oluştuduk
List<string> Kahveler = new List<string>() { "Kahve1: Mocha", "Kahve2: Latte", "Kahve3: Maocha", "Kahve4: Mocha", "Kahve5: Cappucino" };
//Kahveler listemizdeki kahveleri çektik
foreach(string kahve in Kahveler)
{
	//Split metotu ile kahve1 vb. yazan kısımları kestik
	Console.WriteLine(kahve.Split(':').Last());
}