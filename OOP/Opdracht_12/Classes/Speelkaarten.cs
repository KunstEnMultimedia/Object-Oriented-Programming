using System;
using System.Linq;

public class Speelkaart
{
	public enum KaartSoort {A = 1, Twee, Drie, Vier, Vijf, Zes, Seven, Acht, Negen, Tien, Boer, Koningin, Heer}
	public enum Suite {Harten=1, Klaveren, Schoppen, Ruiten}
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

        foreach (KaartSoort kaartSoort in Enum.GetValues(typeof(KaartSoort))) // gaat door de loop heen voor elke enum waarde in KaartSoort (13 keer)
        {
            //{A = 1, Twee, Drie, Vier, Vijf, Zes, Seven, Acht, Negen, Tien, Boer, Koningin, Heer} is de volgorde van toegevoegde items elke loop
            foreach (Suite suite in Enum.GetValues(typeof(Suite)))// gaat door de loop heen voor elke enum waarde in Suite (4 keer) 4x13 = 52
            {
                _kaartenLijst.Add(new Speelkaart(kaartSoort, suite));
                //Console.WriteLine($"{_kaartenLijst.ElementAt(_kaartenLijst.Count-1).KaartType} {_kaartenLijst.ElementAt(_kaartenLijst.Count - 1).KaartNummer}");
                // Harten , Klaveren, Schoppen, Ruiten is de volgorde van toegevoegde items elke loop
            }
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
