using System;
using System.Runtime.Serialization;

class Program
{
    static void Main(string[] args)
    {
        bool continuar = true;
        while (continuar)
        {
            int qtdalunos = 1;
            float soma=0;
            int contalunos = qtdalunos;
            int qtdmedia=0;
            float media=0;
            float somatotal=0;
            while (contalunos <= 10) 
            {
                Console.WriteLine($"Digite a P1 do aluno{contalunos}");
                float nota1 = float.Parse( Console.ReadLine() );
                Console.WriteLine($"Digite a P2 do aluno{contalunos}");
                float nota2 = float.Parse(Console.ReadLine());
                soma = nota1 + nota2;
                somatotal = soma+somatotal;
                media = soma / 2;
                if (media > 5)
                {
                    qtdmedia++;
                }

                contalunos++;
            }
            float mediatotal = somatotal / 20f;
            Console.WriteLine($"{qtdmedia} ALUNOS TIRARAM MAIS QUE 5");
            Console.WriteLine($"A MÉDIA DA CLASSE FOI:{media}");
            
            Console.WriteLine("Deseja encerrar o programa? s/n");

            if (Console.ReadLine() == "S" || Console.ReadLine() == "s")
            {
                Console.WriteLine("Programa encerrado!");
                continuar = false;
            }
        
        }
    }
}