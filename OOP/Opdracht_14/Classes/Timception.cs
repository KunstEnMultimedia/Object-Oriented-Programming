﻿using System;

public class Timception : Exception
{
    public override string ToString()
    {
         string extrainfo = "Exception generated by Marinus.\n";
        return $"{extrainfo} {base.ToString()}";
    }


    public static int ResultaatBerekening(int nummer)
    {
        if (nummer != 0)
        {
            return 100 / nummer;
        }
        else 
        {
            throw new DivideByZeroException("BOEM. ZWAT GAT!");
        }
    }

    public static void TimsMethode()
    {
        throw new Timception();
    }

}
