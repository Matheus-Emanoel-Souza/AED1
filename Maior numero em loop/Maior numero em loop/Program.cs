using System;
//nÃO PODE ACEITAR NUMEROS NEGATIVOS!!!!!!!

class Programa
{
    static void Main(string[] args)
    {
        int num,maior, menor;
        int cont=0, contMaior, contMenor;

        void estrutura()
        {

            do 
            {
                Console.WriteLine("Digite um número!");
                num = int.Parse(Console.ReadLine()!);
                cont++;
                contMaior = cont;
                contMenor = cont;
                maior = num;
                menor = num;
            } while (cont<0);
            do
            {
                Console.WriteLine("Digite um número!");
                num = int.Parse(Console.ReadLine()!);
                cont++;
                if (num <= menor)
                {
                    menor = num;
                    contMenor = cont;
                }
                if(num>= maior)
                {
                    maior = num;
                    contMaior = cont;
                }
            }while ();

        }
        bool continuar = true;
        while(continuar)
        {
            //INICIO DO PROGRAMA.
            estrutura();
            //FIM DO PROGRAMA.
            Console.WriteLine("Deseja encerrar o programa ?");
            if (Console.ReadLine()=="s" || Console.ReadLine() == "S")
            {
                Console.WriteLine("STOP!!");
                continuar = false;
            }
        }
    }
}