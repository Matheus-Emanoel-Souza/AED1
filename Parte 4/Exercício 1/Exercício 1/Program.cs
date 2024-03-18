using System;

class program
{
    static void Main(string[] args)
    {
        bool continua = true;
        while (continua)
        {
            int num, fatorial=1;
            Console.WriteLine("Informe o numero que deseja calcular o fatorial");
            num = int.Parse(Console.ReadLine()!);

            while (num>=1) 
            {
                fatorial = fatorial * num;
                num--;
            }
            Console.WriteLine(fatorial);

            Console.WriteLine("Deseja encerrar o programa ?");
            if (Console.ReadLine() == "s")
            {
                Console.WriteLine("Programa encerrado");
                continua = false;
            }
        }
    }
}