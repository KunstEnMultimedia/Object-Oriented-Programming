public class DigitaleKluis
{
	private int code;

    int aantalPogingen = 0;

	static int maxPogingen = 10;

	public bool CanShowCode { get; set; }

	public int CodeLevel { get { return code / 1000; } }

    static Random random = new Random();

	public int Code 
	{ 
		get
		{  
			if (CanShowCode)
			{ return code; }

			else 
			{ return -666; }
		}

		private set
		{
		  code = value;
		}
	}


	public DigitaleKluis(int code)
	{
		Code = code;
	}

	public bool TryCode(int codeIn)
	{
	    if (aantalPogingen < maxPogingen)
		{
			aantalPogingen++;
			if (codeIn == code)
			{
			 CanShowCode = true; // als je de get van Code wilt testen comment deze lijn
			 Console.WriteLine($"Met {aantalPogingen} pogingen heb jij de juiste code: {Code} geraden, nice!");
			 return true;
			}
			if (codeIn != code && codeIn != -666)
			{
			  Console.WriteLine("Ongelide code");
			  return false;
			}
			else
			{
			  Console.WriteLine("CHEATER");
			  return false;
			}
		}
	    else
	    {
	      Console.WriteLine($"Je {maxPogingen} pogingen zijn opgebruikt, sorry.");
	      return false;
	    }
	}

	public static void BruteForce(DigitaleKluis kluisIn)
	{ 
       
		for (int i = 0;  i <= maxPogingen; i++)// deze doet 11 in plaats van 10 om te laten zien dat je geen pogingen meer hebt
		{
            int geprobeerdecode = random.Next(1,50);
            bool result = kluisIn.TryCode(geprobeerdecode);

			if (result)
			{
				Console.Clear();
				Console.WriteLine($"{geprobeerdecode} Is de goede code, geraden in {kluisIn.aantalPogingen} pogingen." );
				break;
            }
            else
			{ 
		        Console.WriteLine(geprobeerdecode);
            }
        }

	}


	/*
	 [Done]
	 1 Een fullproperty Code met private set.
	 De get van deze property zal altijd -666 teruggeven tenzij CanShowcode op true staat,
	 in dit geval zal de effectieve code worden terug gegeven
	 die in de bijbehorende instantievariabele code staat.

	[Done]
	2 Een overloaded constructor die als parameter een geheel getal toelaat.
	Dit getal zal worden toegewezen aan Code en is duse de toeganscode

	[Done]
	3 Een autoproperty CanShowCode type bool om aan the geven of de code van buitenuit gezien kan worden.

	[Done]
	4 Een read-only property CodeLevel van type int.
	Deze property zal het level van de code teruggeven
	ongeacht CanShowCode. Het level is eenvoudigweg de effectieve
	code gedeeld door 1000 als geheel getal
	dus indien de code 500 is zal 0 worden teruggeven indien de code 2000 is wordt 2 teruggegeven, enz.

	[Done]
	5 een private variabele aantalPogingen om bij te houden hoe vaak
	de gebruiker geprobeerd heeft de code te vinden


	[Done]
	6 Een method TryCode die een getal als parameter heeft.
	De methode geeft een true terug als de code goed is
	anders false.
	Deze method kan gebruikt worden om extern een code te testen
	als de code correct is dan wordt er gemeld dat de code geldig is
	en het aantal poginen wordt weergegeven.
	Als de gebruiker -666 meegeeft dan verschijnt er CHEATER op het scherm.
	Als de code fout is dan wordt er "Ongeldige code" geprint en het aantal pogingen gaat omhoog
	Je mag 10 keer proberen daarna laat de method "Pogingen opgebruikt, sorry" zien.


	[Done]
	7 Bruteforce functie
	 */ 



}
