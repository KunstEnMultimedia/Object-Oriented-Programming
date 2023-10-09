using System;

public class Mens
{
	private int geboortjeJaar = 1970;
	private string lief = "niemand";


	public void VeranderLief(string nieuwLief)
	{
		lief = nieuwLief;
	}
	 public void Praat()
	 {
		Console.WriteLine("Ik ben een mens!");
		//Console.WriteLine($"Ik ben Geboren in {geboortjeJaar}.");
		VertelGeheim();
     }

	public void VertelGeheim()
	{
		if (lief != "niemand")
			Console.WriteLine($"Ik ben verliefd op {lief}");
		else
			Console.WriteLine("Ik ben op niemand verliefd");
	   Console.WriteLine("Ik ben verliefd op Anneke");
	}

	public void StartVerjongingskuur()
	{
		Console.WriteLine("Jeuj. Ik word jonger!");
		geboortjeJaar++;
	}
}
