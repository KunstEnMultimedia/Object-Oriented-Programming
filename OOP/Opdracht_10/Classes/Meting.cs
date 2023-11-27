using System;

class Meting
{
    public int Temperatuur { get; set; }
    public string OpgemetenDoor { get; set; }

    public void ToonMetingInKleur(ConsoleColor kleur)
    {
        Console.ForegroundColor = kleur;
        Console.WriteLine($"{Temperatuur}°C gemeten door: {OpgemetenDoor}");
        Console.ResetColor();
    }
    public void VoegMetingToeEnVerwijder(ref Meting inMeting)
    {
        Temperatuur += inMeting.Temperatuur;
        inMeting.Temperatuur = 0;
        inMeting.OpgemetenDoor = "";
    }

    public Meting GenereerRandomMeting()
    {
        Meting result = new Meting();
        result.Temperatuur = Temperatuur * 2;
        result.OpgemetenDoor = OpgemetenDoor + " Junior";
        return result;
    }
}
