using System;

internal abstract class Dier
{
   internal abstract int MaxLeeftijd {get;}
   internal abstract string MaakGeluid();
}

internal class Wolf : Dier
{
    internal override int MaxLeeftijd 
    {
        get
        {
            return 20;
        }
    }
    internal override string MaakGeluid()
    {
        return "Woef";
    }
}

internal class Paard : Dier
{
    internal override int MaxLeeftijd 
    { 
        get
        { 
            return 25; 
        } 
    }
    internal override string MaakGeluid()
    {
        return "Hinnik";
    }
}
