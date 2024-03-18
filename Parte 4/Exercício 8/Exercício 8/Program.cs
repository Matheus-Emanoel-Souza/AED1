using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite até qual posição deseja ver visualizar a Fibonacci");
        int i = int.Parse(Console.ReadLine());
        int Fibo=1;
        int anterior1 = 0;
        int anterior2 = 0;
        int cont=1;

        while (i>0) 
        {

            Console.WriteLine($"{cont}ª-{Fibo}");
            anterior2 = anterior1;
            anterior1 = Fibo;
            Fibo = anterior1 + anterior2;
            i--;
            cont++;
        }



    }
}

