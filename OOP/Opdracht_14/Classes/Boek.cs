namespace Opdracht_14;
internal class Boek
{
    public int Isbn { get; private set; }
    public string Title { get; private set; }
    public string Auteur { get; private set; }

    protected double prijs;
    public virtual double Prijs 
    {
        get { return prijs; }
        protected set { prijs = value; }
    }

    internal Boek(int _IsbnIn, string _TitleIn, string _AuteurIn, double _PrijsIn) 
    { 
        Isbn = _IsbnIn;
        Title = _TitleIn;
        Auteur = _AuteurIn;
        Prijs = _PrijsIn;
    }

    public override string ToString()
    {
        return $"'{Title}' - {Auteur} ({Isbn}) ${prijs}";
    }

    public static Boek TelOp(Boek _boekIn1, Boek _boekIn2)
    {
        return new Boek(0, $"Omnibus van {_boekIn1.Auteur}, {_boekIn2.Auteur}", $"Auteurs: {_boekIn2.Auteur} & {_boekIn1.Auteur}", _boekIn1.Prijs + _boekIn2.prijs / 2);
    }
}




internal class KoffietafelBoek : Boek
{
    public override double Prijs { 
        get { return prijs; } 
        protected set { prijs = Math.Clamp(value, 36, 99); }
    }

    internal KoffietafelBoek(int _IsbnIn, string _TitleIn, string _AuteurIn, double _PrijsIn) : base(_IsbnIn, _TitleIn, _AuteurIn, _PrijsIn)
    { }
}




internal class TextBoek : Boek
{
    public int Gradelevel { get; private set; }
    public override double Prijs {
        get{ return prijs; }
        protected set{ prijs = Math.Clamp(value, 21, 79); }
    }

    internal TextBoek(int _GradeLevelIn, int _IsbnIn, string _TitleIn, string _AuteurIn, double _PrijsIn) : base(_IsbnIn, _TitleIn, _AuteurIn, _PrijsIn)
    { 
        Gradelevel = _GradeLevelIn;
    }
}

