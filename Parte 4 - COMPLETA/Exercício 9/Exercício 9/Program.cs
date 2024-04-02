//ler valor.
// Desenhar triângulo (meio triangulo) com altura valendo inteiro lido.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número");
        int i = int.Parse(Console.ReadLine());
        int qtdZero = 1;
        int sobe = 1;
        while (i > 0)
        {
            while (qtdZero > 0) 
            {
                Console.Write("0");
                qtdZero--;
            }
            sobe++;
            qtdZero=sobe;
            i--;
            Console.WriteLine("");
        }
        Console.WriteLine("Programa encerrado!");
    }
}