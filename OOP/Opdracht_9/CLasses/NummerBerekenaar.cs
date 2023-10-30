using System;

public class NummerBerekenaar
{
    public float Getal1 { get; set; }
    public float Getal2 { get; set; }

    public float Som()
    {
        return Getal1 + Getal2;
    }
    public float Verschil() 
    { 
       return Getal1 - Getal2;
    }
    public float Product()
    { 
       return Getal1 * Getal2;
    }
    public float Quotient()
    {
        if (Getal1 == 0 || Getal2 == 0)
        {
            Console.WriteLine("Kan niet delen door 0");
            return 0.0f;
        }
        else 
        { 
           return Getal1 / Getal2;
        }
    }
}
