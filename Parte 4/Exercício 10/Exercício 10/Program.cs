//ler valor.
// Desenhar triângulo com altura valendo inteiro lido.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int i = int.Parse(Console.ReadLine());
        int qtdZero = 1;
        int sobe = 1;
        int qtdBranco = i;
        while (i > 0)
        {   
            while (qtdBranco > 0)
            { Console.Write(" ");qtdBranco--; }
            while (qtdZero > 0)
            {
                Console.Write("0");
                qtdZero--;
            }
            qtdBranco = i;
            while (qtdBranco > 0)
            { Console.Write(" "); qtdBranco--; }
            sobe +=2;
            qtdZero = sobe;
            i--;
            qtdBranco = i;
            Console.WriteLine("");

        }
        Console.WriteLine("Programa encerrado!");
    }
}