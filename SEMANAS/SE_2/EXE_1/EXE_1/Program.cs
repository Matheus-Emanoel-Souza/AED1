using System;

class Program
{
    static void Main()
    {
        int[] matricula = new int[8];
        for (int i = 0; i < matricula.Length; i++)
        {
            Console.Write($"Digite o {i + 1}º dígito da matrícula: ");
            matricula[i] = int.Parse(Console.ReadLine());
        }

        int somatorio = matricula[0] * 2 +
                        matricula[1] * 3 +
                        matricula[2] * 4 +
                        matricula[3] * 3 +
                        matricula[4] * 2 +
                        matricula[5] +
                        matricula[6] +
                        matricula[7];

        int digitoVerificador = somatorio % 10;

        Console.Write("Matrícula completa com dígito verificador: ");
        for (int i = 0; i < matricula.Length; i++)
        {
            Console.Write(matricula[i]);
        }
        Console.WriteLine($"-{digitoVerificador}");
    }
}
