using System;
public class Mens
{
    public int MaxLengte { get; set; }
    public enum Geslachten {Man, Vrouw }
    public Geslachten Geslacht { get; set; }

    private static int geboorteJaar = 1;
    public int Geboortejaar
    {
        get { return geboorteJaar; }
        private set { geboorteJaar = value; }
    }


    public void Jarig()
    {
        Geboortejaar++;
    }

    public Mens PlantVoort(Mens dePapa)
    {
        if (Geslacht == Geslachten.Vrouw && dePapa.Geslacht == Geslachten.Man)
        {
            Mens baby = new Mens();
            baby.MaxLengte = MaxLengte;
            if (dePapa.MaxLengte >= MaxLengte)
                baby.MaxLengte = dePapa.MaxLengte;
            return baby;
        }
        return null;
    }
}