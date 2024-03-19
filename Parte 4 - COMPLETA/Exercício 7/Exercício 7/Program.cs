using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        float i = 1;
        float j = 500;
        float Val=0;
        float print;
        int repet = 10;
        while (repet>0) 
        { 
            print = i/j+Val;
            i++;
            j -= 50;
            Val = print;
            repet--;
            if (repet == 1) { Console.WriteLine(print); }
        }

    }
}