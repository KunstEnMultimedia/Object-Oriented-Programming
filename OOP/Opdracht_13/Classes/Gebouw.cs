using System;

public class Gebouw
{
    protected int aantalVerdiepingen { get; private set; }

    public Gebouw(int aantalVerdiepingenIn = 1)
    { 
      aantalVerdiepingen = aantalVerdiepingenIn;
    }

}


public class Apartement : Gebouw
{
    public Apartement():base(15)
    {
        Console.WriteLine("Apartement: Verdiepingen: " + aantalVerdiepingen);
    }

    public Apartement(int aantalVerdiepingenIn) : base(aantalVerdiepingenIn)
    {
        Console.WriteLine("Apartement: Verdiepingen: " + aantalVerdiepingen);

    }
}


public class Huis : Gebouw
{
    protected bool HeeftTuintje { get; private set; }
    protected bool HeeftDeurbel { get; private set; }

    public Huis():base(2)
    { 
      HeeftTuintje = false;
      HeeftDeurbel = false;

      Console.WriteLine($"Huis: Deurbel: {HeeftDeurbel}, Tuintje: {HeeftTuintje}, Verdiepingen {aantalVerdiepingen}");
    }

    public Huis(bool tuintjeIn, bool deurbelIn, int aantalVerdiepingenIn):base(aantalVerdiepingenIn)
    {
        HeeftTuintje = tuintjeIn;
        HeeftDeurbel = deurbelIn;

        Console.WriteLine($"Huis: Deurbel: {HeeftDeurbel }, Tuintje: {HeeftTuintje}, Verdiepingen {aantalVerdiepingen}");
    }
}


public class Villa : Huis
{
    public Villa() : base(false, false, 2)
    { 
        Console.WriteLine($"Villa: Deurbel: {HeeftDeurbel}, Tuintje: {HeeftTuintje}, Verdiepingen {aantalVerdiepingen}");
    }

    public Villa(bool tuintjeIn, bool deurbelIn, int aantalVerdiepingenIn) : base(tuintjeIn, deurbelIn, aantalVerdiepingenIn)
    {
        Console.WriteLine($"Villa: Deurbel: {HeeftDeurbel}, Tuintje: {HeeftTuintje}, Verdiepingen {aantalVerdiepingen}");

    }
}
