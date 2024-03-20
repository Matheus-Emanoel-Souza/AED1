using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string sexoF;
        string Nome;
        int Idade;
        float desconto = 0;
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Digite o seu nome.");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            Idade = int.Parse(Console.ReadLine());
            if (Idade == 0)
            {
                Console.WriteLine("PROGRAMA ENCERRADO!!");
                continuar = false;
            }
            Console.WriteLine("Informe seu Sexo m/f");
            sexoF = Console.ReadLine();




            if (sexoF == "f")
            {
                if (Idade <= 30)
                {
                    desconto = 0.2f;
                }
                if (Idade <= 40 && Idade >= 31)
                {
                    desconto = 0.3f;
                }
                if (Idade >= 41)
                {
                    desconto = 0.35f;
                }
            }
            else
            {
                if (Idade > 25)
                {
                    desconto = 0.25f;
                }
            }
            Console.WriteLine($"O desconto do {Nome} é de: {desconto}!");
        }
    }
}