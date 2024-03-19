using System;

internal class Program
{
    private static void Main(string[] args)
    {
        //Variáveis.
        int i1, i2, DigitoVerificador;
        int somatório;
        //Programa.
        Console.WriteLine("Informe o seu cpf, Número por número.");
        i1 = int.Parse(Console.ReadLine());
        i2 = i1 * 2;
        i1 = int.Parse(Console.ReadLine());
        i2 = i2 + (i1 * 3);
        i1 = int.Parse(Console.ReadLine());
        i2 = i2 + (i1 * 4);
        i1 = int.Parse(Console.ReadLine());
        i2 = i2 + (i1 * 3);
        i1 = int.Parse(Console.ReadLine());
        i2 = i2 + (i1 * 2);
        i1 = int.Parse(Console.ReadLine());
        i2 = i2 + i1;
        i1 = int.Parse(Console.ReadLine());
        i2 = i2 + i1;
        i1 = int.Parse(Console.ReadLine());
        i2 = i2 + i1;
        DigitoVerificador = i2 % 10;
        Console.WriteLine("Seu dígito verificador é de:"+DigitoVerificador);
    }
}