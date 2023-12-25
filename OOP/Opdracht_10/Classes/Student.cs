using System;

namespace NietOpdracht_10
{ 

public class Student
{
    public string Naam { get; set; }

    public Student(string name) 
    //name is de input property voor de constructor
    { 
      Naam = name; // autoproperty wordt name
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
            }//aangezien de de functie altijd type student returned verander ik de naam naar niet gevonden
        }
        return gevonden;
    }
}
}
