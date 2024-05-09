using System;

public class Patient
{
    protected string Naam { get; private set; }
	protected int UrenInZiekenhuis { get; private set; }
	protected int Kosten { get; private set; }

	static Random random = new();
	public Patient(int urenIn, string naamIn)
	{
		UrenInZiekenhuis = urenIn;
		Naam = naamIn;
	}
    public Patient()
    {
		string[] naamArray = { "David", "Marlies", "Marco", "Fleur", "Pieter", "Pjotr", "Phoebe", "Gerben", "Bjorn", "Felix", "Lily", "Pikachu", "Amy", };
        UrenInZiekenhuis = random.Next(0,200);
		Naam = naamArray.ElementAt(random.Next(0, naamArray.Length-1));
    }

    protected virtual int BerekenKost()
	{
	   return Kosten = 50 + UrenInZiekenhuis * 20;
	}

	public void InfoFiche()
	{
		Console.WriteLine($"{Naam}: Uren in ziekenhuis: {UrenInZiekenhuis} Kosten: {BerekenKost()}");
	}
}
