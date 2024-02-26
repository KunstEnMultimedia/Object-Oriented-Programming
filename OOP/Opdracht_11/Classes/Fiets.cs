using System.Diagnostics;

class Fiets
{
    private static int aantalFietsen = 0;
    public Fiets()
    {
        aantalFietsen++;
        Debug.WriteLine($"Er zijn nu {aantalFietsen} gemaakt");
    }
    public static void VerminderFiets()
    {
        aantalFietsen--;
        Debug.WriteLine($"STATIC: Er zijn {aantalFietsen} fietsen");
    }
}