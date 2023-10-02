using System;
using System.Reflection; // nodig voor een string paramater naar een function call omzetten


public class Menu
{
    public static bool menu = true;
    public static void Start()
    {
        menu = false;
        Console.Clear();
        Console.WriteLine("Dit is het verhaal van...");
        string name = Console.ReadLine();
        Console.Clear();
        Console.WriteLine(name + " is een...");
        Console.WriteLine();

        //Menu.Selector("Samurai", "Gunslinger", "Wizard");
        Console.SetCursorPosition(0, 2);

        // hier komt nu een selectie scherm
    }

    public static void Options()
    {
        Console.WriteLine("Sorry nog geen options");
    }

    public static void Quit()
    {
        Environment.Exit(0);
    }

    public void Selector(string function1, string function2 ,string function3, int cursorStart)
    {

        Console.WriteLine(function1);
        Console.WriteLine(function2);
        Console.WriteLine(function3);
        Console.WriteLine();
        menu = true;
        Console.SetCursorPosition(0, cursorStart); //  deze zet de cursor op de y van de cursorStart

        int selected = Console.GetCursorPosition().Top; // pakt de curser position
        int startPos = selected; //pakt de startpositie van de cursor

     while (menu == true)
     {
        ConsoleKey read = Console.ReadKey(true).Key;
        Type type = typeof(Menu);
        MethodInfo method1 = type.GetMethod(function1);// dit pakt de functie met dezelfde naam als de string paramater function 1
        MethodInfo method2 = type.GetMethod(function2);// dit pakt de functie met dezelfde naam als de string paramater function 2
        MethodInfo method3 = type.GetMethod(function3);// dit pakt de functie met dezelfde naam als de string paramater function 3


        if (read == ConsoleKey.DownArrow && Console.CursorTop != Console.WindowHeight - 1)
        {
            Console.SetCursorPosition(0, Console.CursorTop + 1);
        }
        // deze twee if's zorgen voor dat je niet de console crashed door uit de scherm borders gaan
        if (read == ConsoleKey.UpArrow && Console.CursorTop != Console.WindowTop)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }


        selected = Console.GetCursorPosition().Top;
        int trueSelected = selected - startPos; 
        //true selected is een aangepaste selected die zorgt dat het tellen van boven naarbeneden altijd
        //bij 0 start los van waar de curser nu is

            if (trueSelected >= 3) 
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
            }
            // deze twee if statements zorgen ervoor dat je niet uit de slectie box kan

            else if (trueSelected <= -1)
            { 
                Console.SetCursorPosition(0, Console.CursorTop + 1);
            }


            if (read == ConsoleKey.Enter && menu == true)
            // roept de functie die als paramaters die zijn ingevoerd
            // en met Y van de cursor positie kiest hij welke van de drie gekozen wordt
            {
              switch (trueSelected)
              {
                  case (0):
                      method1.Invoke(null, null);
                      break;
                  case (1):
                      method2.Invoke(null, null);
                      break;
                  case (2):
                      method3.Invoke(null, null);
                      break;
              }
            }
         }
       }
    }
