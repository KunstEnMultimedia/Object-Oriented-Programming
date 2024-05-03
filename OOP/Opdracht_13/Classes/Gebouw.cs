using System;

public class Gebouw
{
    int aantalVerdiepingen { get; private set; }

    public Gebouw(int aantalVerdiepingenIn = 1)
    { 
      aantalVerdiepingen = aantalVerdiepingenIn;
    }

}


public class Apartement : Gebouw
{
    public Apartement():base(15)
    {
        Console.WriteLine("aantal verdiepingen:" + aantalVerdiepingen);
    }

    public Apartement(int aantalVerdiepingenIn) : base(aantalVerdiepingenIn)
    {
        Console.WriteLine("aantal verdiepingen:" + aantalVerdiepingen);

    }
}


public class Huis : Gebouw
{
    bool heeftTuintje { get; private set; }
    bool HeeftDeurbel { get; private set; }

    public Huis():base(2)
    { 
      heeftTuintje = false;
      heeftDeurbel = false;

      Console.WriteLine($"Huis: Deurbel: {HeeftDeurbel}, Tuintje: {heeftTuintje}, Verdiepingen {aantalVerdiepingen}");
    }

    public Huis(bool tuintjeIn, bool deurbelIn, int aantalVerdiepingenIn):base(aantalVerdiepingenIn)
    {
        heeftTuintje = tuintjeIn;
        HeeftDeurbel = deurbelIn;

        Console.WriteLine($"Huis: Deurbel: {HeeftDeurbel }, Tuintje: {heeftTuintje}, Verdiepingen {aantalVerdiepingen}");
    }
}


public class Villa : Huis
{
    public Villa() : base(false, false, 2)
    { 
        Console.WriteLine($"Villa: Deurbel: {HeeftDeurbel}, Tuintje: {heeftTuintje}, Verdiepingen {aantalVerdiepingen}");
    }

    public Villa(bool tuintjeIn, bool deurbelIn, bool aantalVerdiepingenIn) : base(tuintjeIn, deurbelIn, aantalVerdiepingenIn)
    {
        Console.WriteLine($"Villa: Deurbel: {HeeftDeurbel}, Tuintje: {heeftTuintje}, Verdiepingen {aantalVerdiepingen}");

    }
}
