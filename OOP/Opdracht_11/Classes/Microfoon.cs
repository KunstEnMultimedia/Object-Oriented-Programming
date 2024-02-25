class Microfoon
{
    public string Merk { get; set; }
    public bool IsUitverkocht { get; set; }


    public Microfoon(string merkIn, bool isUitverkochtIn)
    {
        IsUitverkocht = isUitverkochtIn;
        Merk = merkIn;
    }

    public Microfoon(string merkIn) : this(merkIn, false)
    { }

    public Microfoon() : this("Onbekend", true)
    { }

    public Microfoon(bool isUitverkochtIn) : this("Bovarc", isUitverkochtIn)
    {
        Merk = "Wit Product"; // dit zorgt voor altijd wit product merk
        IsUitverkocht = isUitverkochtIn;
        if (IsUitverkocht)
        {
            Console.WriteLine($"{Merk} is uitverkocht");
        }
        else
        {
            Console.WriteLine($"{Merk} is niet uitverkocht");
        }
    }

}