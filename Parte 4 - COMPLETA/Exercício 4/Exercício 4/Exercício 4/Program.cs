//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        float ValCompra = 0;
//        float ValPago =0;
//        Console.WriteLine("Escreva o valor da compra:");
//        ValCompra = float.Parse(Console.ReadLine()!);
//        Console.WriteLine("Escreva o valor da compra:");
//        ValPago = float.Parse(Console.ReadLine()!);
//        float Troco = ValPago - ValCompra;
//    }
//}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor total da compra:");
        decimal valorCompra = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor pago:");
        decimal valorPago = decimal.Parse(Console.ReadLine());

        decimal troco = valorPago - valorCompra;

        Console.WriteLine("Troco a ser dado: " + troco);


        // Calculando quantidade de notas de 50
        int notas50 = (int)(troco / 50);
        troco %= 50;

        // Calculando quantidade de notas de 20
        int notas20 = (int)(troco / 20);
        troco %= 20;

        // Calculando quantidade de notas de 10
        int notas10 = (int)(troco / 10);
        troco %= 10;

        // Calculando quantidade de notas de 5
        int notas5 = (int)(troco / 5);
        troco %= 5;

        // Calculando quantidade de notas de 2
        int notas2 = (int)(troco / 2);
        troco %= 2;

        // Calculando quantidade de moedas de 1
        int moedas1 = (int)troco;
        troco -= moedas1;

        // Arredondando para duas casas decimais para evitar erros de precisão
        troco = Math.Round(troco, 2);

        Console.WriteLine("Notas de 50: " + notas50);
        Console.WriteLine("Notas de 20: " + notas20);
        Console.WriteLine("Notas de 10: " + notas10);
        Console.WriteLine("Notas de 5: " + notas5);
        Console.WriteLine("Notas de 2: " + notas2);
        Console.WriteLine("Moedas de 1: " + moedas1);
        Console.WriteLine("Troco restante (em centavos): " + troco * 100);
    }
}