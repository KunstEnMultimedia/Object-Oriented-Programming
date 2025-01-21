using System;

public class RechtHoek : GeometricFigure
{
    public RechtHoek(float hoogte, float breedte) 
    {
        Hoogte = hoogte;
        Breedte = breedte;
    }

    protected override float BerekenOppervlakte()
    {
        return Breedte * Hoogte;
    }
}
