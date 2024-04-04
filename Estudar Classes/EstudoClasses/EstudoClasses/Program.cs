using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


class Program
{
    static void Main()
    {
        bool continua = true;
        int MelhorTempo = int.MaxValue;
        int qtdcorredor = 0;
        string NomeMelhorCorredor = "";
        float media=0;
        float soma=0, qtdTotal=0;

        while (continua)
        {
            qtdTotal++;

            Console.WriteLine("Informe o nome do corredor:");
            string nomeCorre = Console.ReadLine()!;

            Console.WriteLine("Informe quanto tempo em segundos ele levou para correr(Segundos):");
            int tempocorre = int.Parse(Console.ReadLine()!);
            soma = soma + tempocorre;

            if (tempocorre < 76)
            {
                qtdcorredor++;
            }


            if (MelhorTempo > tempocorre)
            {
                MelhorTempo = tempocorre;
                NomeMelhorCorredor = nomeCorre;
            }
               
            Console.WriteLine("Deseja encerrar o programa ? (s/n)");

            if (Console.ReadLine() == "n")
            {
                continua = true;
            }
            else
            {
                continua = false;
            }
            media = soma / qtdTotal; 
        }
        Console.WriteLine($"O nome do melhor corredor é:{NomeMelhorCorredor}");
        Console.WriteLine($"Seu tempo foi de:{MelhorTempo}");
        Console.WriteLine($"A quantidade de corredores que levaram menos de 76 é de: {qtdcorredor}");
        Console.WriteLine($"A média dos corredores é de: {media}");
    }
}
