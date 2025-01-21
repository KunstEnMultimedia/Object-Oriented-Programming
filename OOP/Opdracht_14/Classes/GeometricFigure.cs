using System;

public abstract class GeometricFigure
{
    public float Hoogte { get; set; } = 10;
    public float Breedte { get; set; } = 10;

    public float Oppervlakte {  get { return BerekenOppervlakte();  } }
    protected abstract float BerekenOppervlakte();
}
