using System;

public class Balletje
{
    public int X { get; set; }
    public int Y { get; set; }
    public int VectorX { get; set; }
    public int VectorY { get; set; }
    
    static Random rng = new Random();

    public Balletje(int xin, int yin, int vxIn, int vyIn)
    {
         X = xin;
         Y = yin;
         VectorX = vxIn;
         VectorY = vyIn;
    }


    public Balletje()
    {
        X = rng.Next(0, Console.WindowWidth);
        Y = rng.Next(0, Console.WindowWidth);
        VectorX = rng.Next(-2, 3);
        VectorY = rng.Next(-2, 3);
    }

    public void Update()
        {
           if (X + VectorX >= Console.WindowWidth || X + VectorX < 0)
           { 
             VectorX = -VectorX;
           }
           X = X + VectorX;
           
           if (Y + VectorY >= Console.WindowHeight || Y + VectorY < 0)
           {
               VectorY = -VectorY;
           }
           Y = Y + VectorY;
        }

    public void TekenOpScherm()
    {
        Console.SetCursorPosition(X, Y);
        Console.Write("O");
    }

}
