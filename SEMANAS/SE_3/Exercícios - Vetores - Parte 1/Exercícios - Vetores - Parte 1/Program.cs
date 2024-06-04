using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Escolha o exercício que deseja acessar:");
        Console.WriteLine("1. Exercício 01");
        Console.WriteLine("2. Exercício 02");
        Console.WriteLine("3. Exercício 03");
        Console.WriteLine("4. Exercício 04");
        Console.WriteLine("5. Exercício 05");
        Console.WriteLine("6. Exercício 06");
        Console.WriteLine("7. Exercício 07");
        Console.WriteLine("8. Exercício 08");
        Console.WriteLine("9. Exercício 09");
        Console.WriteLine("10. Exercício 10");
        Console.WriteLine("11. Exercício 11");
        Console.WriteLine("12. Exercício 12");
        Console.WriteLine("13. Exercício 13");
        Console.WriteLine("14. Exercício 14");
        Console.Write("Opção: ");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Exercicio01();
                break;
            case 2:
                Exercicio02();
                break;
            case 3:
                Exercicio03();
                break;
            case 4:
                Exercicio04();
                break;
            case 5:
                Exercicio5();
                break;
            case 6:
                Exercicio6();
                break;
            case 7:
                Exercicio7();
                break;
            case 8:
                Exercicio8();
                break;
            case 9:
                Exercicio9();
                break;
            case 10:
                Exercicio10();
                break;
            case 11:
                Exercicio11();
                break;
            case 12:
                Exercicio12();
                break;
            case 13:
                Exercicio13();
                break;
            case 14:
                Exercicio14();
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }

    static void Exercicio01()
    {
        int[] vetor = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números digitados:");
        foreach (int num in vetor)
        {
            Console.Write(num + " ");
        }
    }

    static void Exercicio02()
    {
        int[] vetor = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números digitados em ordem inversa:");
        for (int i = vetor.Length - 1; i >= 0; i--)
        {
            Console.Write(vetor[i] + " ");
        }
    }

    static void Exercicio03()
    {
        int[] vetor = new int[10];
        int[] pares = new int[10];
        int[] impares = new int[10];
        int countPares = 0;
        int countImpares = 0;

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
            if (vetor[i] % 2 == 0)
            {
                pares[countPares] = vetor[i];
                countPares++;
            }
            else
            {
                impares[countImpares] = vetor[i];
                countImpares++;
            }
        }

        Console.WriteLine("Números pares:");
        for (int i = 0; i < countPares; i++)
        {
            Console.Write(pares[i] + " ");
        }

        Console.WriteLine("\nNúmeros ímpares:");
        for (int i = 0; i < countImpares; i++)
        {
            Console.Write(impares[i] + " ");
        }
    }
    static void Exercicio04()
    {
        char[] vetor = new char[10];
        int vogaisCount = 0;

        Console.WriteLine("Digite 10 caracteres:");

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = char.Parse(Console.ReadLine());
        }

        Console.WriteLine("Vogais presentes no vetor:");
        foreach (char c in vetor)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
            {
                Console.Write(c + " ");
                vogaisCount++;
            }
        }

        if (vogaisCount == 0)
        {
            Console.WriteLine("Nenhuma vogal presente no vetor.");
        }
    }

    static void Exercicio5()
    {
        double[] vetor = new double[10];
        double soma = 0;

        Console.WriteLine("Digite 10 números reais:");

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = double.Parse(Console.ReadLine());
            soma += vetor[i];
        }

        double media = soma / vetor.Length;
        Console.WriteLine("Média dos valores: " + media);
    }

    static void Exercicio6()
    {
        int[] vetor = new int[10];

        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        int maior = vetor[0];
        int menor = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i] > maior)
            {
                maior = vetor[i];
            }
            if (vetor[i] < menor)
            {
                menor = vetor[i];
            }
        }

        Console.WriteLine("Maior valor: " + maior);
        Console.WriteLine("Menor valor: " + menor);
    }
    static void Exercicio7()
    {
        string[] vetor = new string[10];

        Console.WriteLine("Digite 10 palavras:");

        for (int i = 0; i < vetor.Length; i++)
        {
            vetor[i] = Console.ReadLine();
        }

        string maiorPalavra = vetor[0];
        string menorPalavra = vetor[0];

        for (int i = 1; i < vetor.Length; i++)
        {
            if (vetor[i].Length > maiorPalavra.Length)
            {
                maiorPalavra = vetor[i];
            }
            if (vetor[i].Length < menorPalavra.Length)
            {
                menorPalavra = vetor[i];
            }
        }

        Console.WriteLine("Maior palavra: " + maiorPalavra);
        Console.WriteLine("Menor palavra: " + menorPalavra);
    }

    static void Exercicio8(int[] vetor)
    {
        Console.WriteLine("Valores do vetor:");
        foreach (int num in vetor)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void Exercicio9()
    {
        int[] vetor1 = new int[9];
        int[] vetor2 = new int[9];
        int[] vetor3 = new int[9];

        Console.WriteLine("Digite 9 números para o primeiro vetor:");
        for (int i = 0; i < vetor1.Length; i++)
        {
            vetor1[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite 9 números para o segundo vetor:");
        for (int i = 0; i < vetor2.Length; i++)
        {
            vetor2[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Digite 9 números para o terceiro vetor:");
        for (int i = 0; i < vetor3.Length; i++)
        {
            vetor3[i] = int.Parse(Console.ReadLine());
        }

        int[] vetorResultado = new int[27];
        Array.Copy(vetor1, 0, vetorResultado, 0, 3);
        Array.Copy(vetor2, 0, vetorResultado, 9, 3);
        Array.Copy(vetor3, 0, vetorResultado, 18, 3);

        Console.WriteLine("Vetor resultante:");
        foreach (int num in vetorResultado)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
    static void Exercicio10()
    {
        int[] vetorA = { 1, 4, 2, 1, 5 };
        int[] vetorB = { 1, 5, 2, 1, 5, 6, 3, 7 };

        Console.WriteLine("Saída do Programa:");
        foreach (int numA in vetorA)
        {
            foreach (int numB in vetorB)
            {
                if (numA == numB)
                {
                    Console.Write(numA + " ");
                }
            }
        }
        Console.WriteLine();
    }

}
