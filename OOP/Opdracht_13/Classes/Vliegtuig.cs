public class Vliegtuig
{
    public virtual void Vlieg()
    {
        Console.WriteLine("Je vliegt rustig tussen de wolken");
    }
}

public class Raket : Vliegtuig
{
    public override void Vlieg()
    {
        Console.WriteLine("Je schiet omhoog en verwdijnt in de ruimte");
    }
}