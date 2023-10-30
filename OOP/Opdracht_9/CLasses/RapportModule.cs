using System;

public class RapportModule
{
    public int Percentage { get; set; }

    public void PrintGraad()
    { 
      switch (Percentage) 
        { 
          case >=85:
              Console.WriteLine("Grootste onderscheiding");
              break;
          case >= 75:
              Console.WriteLine("Grote onderscheiding");
              break;
          case >= 68:
              Console.WriteLine("Onderscheiding");
              break;
          case > 50:
              Console.WriteLine("Voldoende");
              break;
          case <= 50:
              Console.WriteLine("Niet Geslaagd");
              break;
        }
    }

}
