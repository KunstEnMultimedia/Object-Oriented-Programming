using System;

public class Restaurant
{
    protected int Kosten { get; set; }
    public virtual int PoetsAlles()
    {
         return Kosten += 1000;
    }
}

public class Frituur : Restaurant
{
    public override int PoetsAlles()
    {
         return Kosten = base.PoetsAlles() + 500;
    }

}
