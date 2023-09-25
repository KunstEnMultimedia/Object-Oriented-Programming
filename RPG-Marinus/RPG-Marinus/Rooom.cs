using System;
using System.Reflection;

public class Menu
{
    public bool menu = true;
    public int Y = 0;
    public void Update()
    {

    }
    public static void Start()
    {
        Console.Clear();
        Console.WriteLine("Dit is het verhaal van...");
        string name = Console.ReadLine();
        Console.Clear();
        Console.WriteLine(name + " is een...");
        Console.WriteLine();
        Console.WriteLine("Samurai");
        Console.WriteLine("Gunslinger");
        Console.WriteLine("Mage");
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

    public void Selector(string function1, string function2 ,string function3)
    {
     menu = true;
     while (menu == true)
     {
        ConsoleKey read = Console.ReadKey().Key;
        Type type = typeof(Menu);
        MethodInfo method1 = type.GetMethod(function1);
        MethodInfo method2 = type.GetMethod(function2);
        MethodInfo method3 = type.GetMethod(function3);


        if (read == ConsoleKey.DownArrow && Console.CursorTop != Console.WindowHeight - 1)
        {
            Console.SetCursorPosition(0, Console.CursorTop + 1);
            //Console.WriteLine("DOWN");
        }

        if (read == ConsoleKey.UpArrow && Console.CursorTop != Console.WindowTop)
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            //Console.WriteLine("Up");
        }

        int selected = Console.GetCursorPosition().Top;
        if (read == ConsoleKey.Enter && menu == true)
        {
            switch (selected)
            {
                case (0):
                    menu = false;
                    method1.Invoke(null, null);
                    // hier wil ik een command doen die je als input kan gebruik voor de functie
                    //Invoke("function1", 0.1f);
                    break;
                case (1):
                    method2.Invoke(null, null);
                    // hier wil ik een command doen die je als input kan gebruik voor de functie
                    //Invoke("function2", 0.1f);
                    break;
                case (2):
                    method3.Invoke(null, null);
                    // hier wil ik een command doen die je als input kan gebruik voor de functie
                    //Invoke("function3", 0.1f);
                    break;
     }
            }
         }
       }
    }
