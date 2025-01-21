using System;

public class Vierkant : RechtHoek
{
    public Vierkant(float hoogte, float breedte) : base(hoogte, breedte) 
    {
        if (hoogte != breedte)
        { 
            Hoogte = (hoogte + breedte) / 2;
            Breedte = Hoogte;
        }
    }

    public Vierkant(float hoogteBreedte) : base(0,0)
    {
        Hoogte = hoogteBreedte;
    }
}