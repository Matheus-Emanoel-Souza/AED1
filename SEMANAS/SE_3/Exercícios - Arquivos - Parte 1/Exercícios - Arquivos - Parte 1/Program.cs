using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o exercício que deseja acessar:");
        Console.WriteLine("1. Exercício 1");
        Console.WriteLine("2. Exercício 2");
        Console.WriteLine("3. Exercício 3");
        Console.WriteLine("4. Exercício 4");
        Console.Write("Opção: ");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Exercicio1();
                break;
            case 2:
                Exercicio2();
                break;
            case 3:
                Exercicio3();
                break;
            case 4:
                Exercicio4();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    static void Exercicio1()
    {
        string[] numeros = File.ReadAllLines("numeros.txt");
        int numero1 = int.Parse(numeros[0]);
        int numero2 = int.Parse(numeros[1]);
        int soma = numero1 + numero2;
        Console.WriteLine("A soma dos dois números é: " + soma);
    }

    static void Exercicio2()
    {
        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());
        int soma = numero1 + numero2;
        File.WriteAllText("soma.txt", soma.ToString());
        Console.WriteLine("Soma gravada em arquivo com sucesso!");
    }

    static void Exercicio3()
    {
        string[] numeros = File.ReadAllLines("numeros.txt");
        foreach (string numero in numeros)
        {
            double num = double.Parse(numero);
            double raiz = Math.Sqrt(num);
            Console.WriteLine("Raiz quadrada de " + num + ": " + raiz);
        }
    }

    static void Exercicio4()
    {
        string letras = File.ReadAllText("letras.txt");
        int vogais = 0, consoantes = 0, digitos = 0;
        foreach (char letra in letras)
        {
            if (char.IsLetter(letra))
            {
                if ("AEIOUaeiou".Contains(letra))
                    vogais++;
                else
                    consoantes++;
            }
            else if (char.IsDigit(letra))
            {
                digitos++;
            }
        }
        Console.WriteLine("Total de vogais: " + vogais);
        Console.WriteLine("Total de consoantes: " + consoantes);
        Console.WriteLine("Total de dígitos: " + digitos);
    }
}
