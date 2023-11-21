using System;

public class Student
{
    public string Naam { get; set; }

    public Student(string name) 
    //name is de input property voor de constructor
    { 
      Naam = name; // autoproperty wordt name
    }
}
