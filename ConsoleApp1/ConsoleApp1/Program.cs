using System;
using System.Security.Cryptography.X509Certificates;

bool continuar = true;
int OPCAO;
double PI = 3.141592;


while (continuar)
{
    Console.Clear();
    Console.WriteLine("programa calcular área");
    inicio();
    void inicio()
    {
        Console.WriteLine("Informe a área que deseja calcular:\n 1. Triangulo. \n 2. Retângulo \n 3. circunferência");

        OPCAO = int.Parse(Console.ReadLine());
        switch (OPCAO)
        {
            case 1:
                calculartriangulo();
                break;
            case 2:
                calcularRetangulo();
                break;
            case 3:
                calcularcircunferencia(PI);
                break;
            default:
                Console.WriteLine("Opção inválida! \n Tente novamente!");
                inicio();
                break;

        }

        static void calculartriangulo()
        {
            Console.WriteLine("Digite a altura do triangulo!");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a base do triangulo");
            float basetri = float.Parse(Console.ReadLine());
            float areadotri = (altura * basetri) / 2;
            Console.WriteLine($"A área do Triâangulo é: {areadotri}");
        }

        static void calcularRetangulo()
        {
            Console.WriteLine("Digite a base do Retângulo!");
            float baseret = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura do Retângulo!");
            float altura = float.Parse(Console.ReadLine());
            float areadoret = (altura * baseret);
            Console.WriteLine($"A área do retangulo é: {areadoret}");
        }

        static void calcularcircunferencia(double PI)
        {

            Console.WriteLine("Digite o raio do circulo!");
            double Diâmetro = 2 * (double.Parse(Console.ReadLine()));
            double areacirculo = Diâmetro * PI;
            Console.WriteLine($"A área do retangulo é: {areacirculo}");
        }




        Console.WriteLine("Deseja continuar ? s/n");
        if (Console.ReadLine() == "n")
        {
            Console.WriteLine("fIM DO PROGRAMA!");
            continuar = false;
        }
    }
}

//Dúvidas: Pedir para me explicar melhor a função static.
//Explicar melhor a funcão void. (Vazio) retorna vazio mas as variáveis retornam com conteudo.