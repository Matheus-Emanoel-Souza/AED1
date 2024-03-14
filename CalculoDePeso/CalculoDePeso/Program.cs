using System;

class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("INFORME UM NÚMERO");
            int num = int.Parse(Console.ReadLine());
            int cont=0, prinnt= num*cont;
            while (cont <= 9)
            {
                prinnt = num * cont;
                Console.WriteLine($"{prinnt}");
                cont++;
            }
            Console.WriteLine("Deseja continuar rodando o programa? s/n");
            if (Console.ReadLine() == "n") 
            {
                continuar = false;
            }
        }
    }
}