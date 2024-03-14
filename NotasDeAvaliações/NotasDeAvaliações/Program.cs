using System;
using System.Net.Http.Headers;
using System.Numerics;

class Program
{
    static void Main()
    {
        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("INICIO DO PROGRAMA!!");
            Principal();
            Console.WriteLine("Você desejaa encerrar o programa? s/n");
            if (Console.ReadLine() =="s")
            {
                continuar = false;
            }
        }
    }
    static void Principal()
    {
        Console.WriteLine("Informe a nota da N1");
        float N1 = float.Parse(Console.ReadLine());
        float N1P = 0.3f;
        Console.WriteLine("Informe a nota da N2");
        float N2 = float.Parse(Console.ReadLine());
        float N2P = 0.3f;
        Console.WriteLine("Informe a nota da N1");
        float semestral = float.Parse(Console.ReadLine());
        float semestralp = 0.4f;

        float mediaponderada = (N1 * N1P) + (N2 * N2P) + (semestral * semestralp);
        float notafinal = mediaponderada;
        Console.WriteLine($"A SUA NOTA FINAL É DE:{notafinal}");

    }

}