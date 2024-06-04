//rEALIZAR LEITURA DE 20 NÚMEROS
//USUÁRIO DEVE ESCOLHER METODO BOLHA OU SELEÇÃ SWITCH;
//USUÁRIO DEVE ESCOLHER SE DESEJA EM CRESCENTE OU DECRESCENTE;
//1 - LER OS DADOS 
//2 - ORDENAS DADOS
//3 - IMPRIMIR DADOS 

using System;
using System.ComponentModel.Design;

class Program
{
    static void bolha(int[] digitos)
    {
        int tamanho = digitos.Length;
        int i,j;

        for (j = 0; j < 4; j++)
        {
            for (i = 0; i < tamanho - 1; i++)
            {
                int num = digitos[i];
                if (digitos[i] > digitos[i + 1])
                {
                    digitos[i] = digitos[i + 1];
                    digitos[i + 1] = num;
                }

            }

        }
    }
    static void Selecao(int[] digitos) { 
    
        int[] Newdigitos = new int[digitos.Length];
        
        for (int i = 0;i < Newdigitos.Length; i++)
        {
            
        }
    }

    static void Main()
    {
        int[] numeros = new int[5] {5,4,3,2,1 };

        //Console.WriteLine("Digite 5 numeros!");
        //for (int i = 0; i < 5; i++)
        //{
        //    Console.WriteLine($"Número {i + 1}:");
        //    numeros[i] = int.Parse(Console.ReadLine()!);
        //}
        Console.Clear();
        Console.WriteLine("5 NÚMEROS INFORMADO COM SUCESSO !!!\n");

       // Console.WriteLine("Qual metodo deseja utilizar para ordenar os dados:\n1 - Bolha.\n2 - Seleção");
        int order = 1;/*int.Parse(Console.ReadLine()!);*/
        switch (order)
        {
            case 1: bolha(numeros);
                break;
            case 2: Selecao(numeros);
                break;
            default: Console.WriteLine("escolha inválida!!");
                break;
        }


    }
}
