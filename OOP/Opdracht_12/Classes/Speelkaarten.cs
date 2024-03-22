using System;
using System.Linq;

public class Speelkaart
{
	public enum KaartSoort {A = 1, Twee, Drie, Vier, Vijf, Zes, Seven, Acht, Negen, Tien, Boer, Koningin, Heer, Leeg}
	public enum Suite {Harten=1, Klaveren, Schoppen, Ruiten, Leeg}
	public KaartSoort KaartNummer { get; set; }
	public Suite KaartType { get; set; }
	public static List<Speelkaart> KaartenLijst { get; set; } // onthoud de vraagteken

    static Random rnd = new Random();

	public Speelkaart(KaartSoort _kaartNummer, Suite _kaartType)
    {
        KaartNummer = _kaartNummer;
        KaartType = _kaartType;
    }


	public static List<Speelkaart> MaakSpel()
	{
		List<Speelkaart> _kaartenLijst = new List<Speelkaart>();

		for (int i = 1; i <= 13; i++)//maakt 52 kaarten verdeeld over Harten, Schoppen Ruiten en Klaveren.
		{
		    Suite _suite = (Suite)i;
            _kaartenLijst.Add(new Speelkaart(KaartSoort.Leeg, Suite.Harten));
            _kaartenLijst.Add(new Speelkaart(KaartSoort.Leeg, Suite.Schoppen));
            _kaartenLijst.Add(new Speelkaart(KaartSoort.Leeg, Suite.Klaveren));
            _kaartenLijst.Add(new Speelkaart(KaartSoort.Leeg, Suite.Ruiten));
		}
	    int a = 1;
		foreach(Speelkaart kaart in _kaartenLijst)
		{
			if (a == 14)
			{ 
				a = 1;
			}
			kaart.KaartNummer = (KaartSoort)a;
			a++;
		}
		return _kaartenLijst;
	}

	public static void checkDeck(List<Speelkaart> _deck)
	{
	  Console.WriteLine("Druk op enter om een kaart de pakken");
		for (int i = 1; _deck.Count >= 0; i++)
		{ 
		Opnieuw:
			ConsoleKey input = Console.ReadKey().Key;
			if (input == ConsoleKey.Enter)
			{

			}
			else
			{
				goto Opnieuw;
			}
			int Chosen = rnd.Next(0, _deck.Count);
			if (_deck.Count == 0)
			{
				break;
			}
			Console.WriteLine($"{_deck.Count} {_deck.ElementAt(Chosen).KaartNummer} {_deck.ElementAt(Chosen).KaartType}" );
			_deck.RemoveAt(Chosen);
		}
	}
}
