using System;

class Program
{
     static void Main(string[] args)
    {
        int soma = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Digite um número!({i})");
            int num = int.Parse(Console.ReadLine()!);
            soma = soma + num;
        }
        Console.WriteLine($"A soma dos 10 números é de:{soma}");
    }
}