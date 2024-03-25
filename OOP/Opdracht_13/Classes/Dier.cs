public class Paard : Dier
{
    public bool KanHinnikken { get; set; }

    protected internal void MaakOuder()
    {
        geboorteJaar++;
    }
}
public class Dier
{
    protected internal int geboorteJaar = 2000;
    public void Eet()
    {
       
    }


}