using System;
class Program
{
    static void Main(string[]args)
    {

        bool continuar = true;

        //Repetição do programa geral.
        while (continuar)
        {
            Console.WriteLine("Inicio do programa!");

            //entrada das variáveis.
            bool numpositivo = false;
            int m = 0, n = 0, produto = 1;

            while (!numpositivo)
            {
                Console.WriteLine("Imprima dois valores separadamente");
                m = int.Parse(Console.ReadLine()!);
                n = int.Parse(Console.ReadLine()!);
                if (m >= 0 && n >= 0)
                {
                    numpositivo = true;
                }
                else
                {
                    Console.WriteLine("Numero inválidos, por favor digite novamente numeros POSITIVOS!");
                }
            }
            Console.WriteLine("------------------------------------------------------------------");

            //Classifiquei qual é o maior e qual o menor.
            int numMaior, numMenor;
            if (n > m)
            {
                numMaior = n;
                numMenor = m;
            }
            else {
                numMaior = m;
                numMenor = n;
            }
            //ordem decrescente.
            while (numMenor <= numMaior)
            {
                Console.WriteLine(numMaior);
                produto = produto * numMaior;
                numMaior--;
            };
            //Resetando valores. 
            numMaior = m; numMenor = n;
            //corrige valores.
            if (n > m)
            {
                numMaior = n;
                numMenor = m;
            }
            //ordem crescente.
            while (numMenor <= numMaior)
            {

                Console.WriteLine(numMenor);
                produto = produto * numMenor;
                numMenor++;
            }
            //ordem crescente.
            Console.WriteLine($"O produto dos números impressos é de:{produto}");

            Console.WriteLine("Deseja encerrar o programa? s/n");
            if (Console.ReadLine() == "s")
            {
                Console.WriteLine("Programa encerrado");
                continuar = false;            
            }
        }
    }
}