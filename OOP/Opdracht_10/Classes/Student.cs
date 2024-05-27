using System;

public class Student
{
    public string Naam { get; set; }
    public bool IsWerkStudent { get; set; }

    public int GeboorteJaar { get; set; } = 2000;
        
    public Student() 
    {
        Random ran = new Random();
        List<string> names = new List<string>() {"Bob", "Piet", "Arjen"}; 
        string name = names.ElementAt(ran.Next(0,names.Count));
        Naam = name;
    }

    public override string ToString()
    {
        return $"{Naam} ({GeboorteJaar})";
    }

    public override bool Equals(object? obj)
    {
        Student temp = obj as Student;
        return GeboorteJaar == temp.GeboorteJaar && Naam == temp.Naam;
    }


    //overloaded 1
    public Student(string name) 
    //name is de input property voor de constructor
    { 
      Naam = name; // autoproperty wordt name
    }

    public Student(string name, bool iswerkstudent)
    { 
      Naam = name;
      IsWerkStudent = iswerkstudent;
        if (iswerkstudent)
        {
            Console.WriteLine($"{Naam} is wel een werkstudent");
        }
        else
        {
            Console.WriteLine($"{Naam} is geen werkstudent");
        }
    }
    public static Student ZoekStudent(Student[] array, string naam)
    {
        Student gevonden = null;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Naam == naam)
            { 
               gevonden = array[i];
               break;// als de naam overeen komt wordt element op i het student object wat terug gegeven wordt
            }

            if (array[i].Naam != naam)
            { 
               gevonden = new Student("Niet gevonden");
            }  //aangezien de de functie altijd type student returned verander ik de naam naar niet gevonden
        }
        return gevonden;
    }
}
