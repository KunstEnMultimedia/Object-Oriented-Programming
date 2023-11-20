using System;

public class Persoon
{
    public string Voornaam { get; set; }
    public string Achternaam { get; set; }
    
    DateTime geboorteDatum = DateTime.Now; // wordt ingesteld als datetime.now zodat ik hem niet later
    // terug hoef te zetten in de GeboorteDatum property als de waarde niet klopt

    public DateTime GeboorteDatum
    { 
        get
        {
           return geboorteDatum;
        }
        set
        { 
           if(value >= DateTime.MinValue.AddYears(1990) && value <= DateTime.Now)
           geboorteDatum = value;
        }
    }

}
