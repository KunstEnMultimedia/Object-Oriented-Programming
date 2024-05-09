using System;

public class Patient
{
    public string Naam { get; protected set; }
	public int UrenInZiekenhuis { get; protected set; }
	public int Kosten { get; protected set; }

	private static Random random = new();
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

	public virtual void InfoFiche()
	{
		Console.WriteLine($"{Naam}: Uren in ziekenhuis: {UrenInZiekenhuis} Kosten: {BerekenKost()}");
	}
}

public class VerzekerdePatient : Patient
{
    protected override int BerekenKost()
    {
		return Kosten = base.BerekenKost() * 90 / 100;
    }
    public override void InfoFiche()
    {
        Console.WriteLine($"{Naam} (Verzekerd): Uren in ziekenhuis: {UrenInZiekenhuis} Kosten: {BerekenKost()}");
    }
}
