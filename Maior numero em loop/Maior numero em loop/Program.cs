//nÃO PODE ACEITAR NUMEROS NEGATIVOS!!!!!!!

internal class Programa
{
    private static void Main(string[] args)
    {
        int num, maior = 0, menor = 0;
        bool continuar2 = true;

        void estrutura()
        {
            while (continuar2)
            {
                Console.WriteLine("Digite um número!");
                num = int.Parse(Console.ReadLine()!);
                if (num == -1)
                {
                    continuar2 = false;
                }
                if (num <= menor)
                {
                    menor = num;
                }
                if (num >= maior && num != -1)
                {
                    maior = num;
                }
            }
            Console.WriteLine($"O maior numero digitado foi:{maior}.\nO menor numero digitado foi:{menor}.");
        }

        bool continuar = true;
        while (continuar)
        {
            //INICIO DO PROGRAMA.
            estrutura();
            //FIM DO PROGRAMA.
            Console.WriteLine("Deseja encerrar o programa ?");
            if (Console.ReadLine() == "s" || Console.ReadLine() == "S")
            {
                Console.WriteLine("STOP!!");
                continuar = false;
            }
        }
    }
}