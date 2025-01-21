using System;

public class DrieHoek : GeometricFigure
{
    public DrieHoek(float hoogte, float breedte)
    {
        Hoogte = hoogte;
        Breedte = breedte;
    }

    protected override float BerekenOppervlakte()
    {
        return Breedte * Hoogte / 2;
    }
}
