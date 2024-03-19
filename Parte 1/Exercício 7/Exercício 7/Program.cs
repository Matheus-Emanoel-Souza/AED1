using System;

class Program
{
    static void Main(string[] args)
    {
        //Variáveis.
        string NomeDoProfessor;
        int Matricula, HS, Titulacao;
        float valorPago=0;
        //Declaração
        Console.WriteLine("Digite o nome do Professor!");
        NomeDoProfessor = Console.ReadLine();
        Console.WriteLine("Digite a Matrícula do Professor!");
        Matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("Informe as Horas semanais");
        HS = int.Parse(Console.ReadLine());
        do
        {
            Console.WriteLine($"Informe a titulação do {NomeDoProfessor}.\\n1.Especialista\\n2.Mestre\\n3.Doutor");
            if (!int.TryParse(Console.ReadLine(), out Titulacao))
            {
                Console.WriteLine("Por Favor, digite um número válido (1,2 ou 3).");
                continue;
            }

            if (Titulacao == 1)
            {
                valorPago = HS * 15;
            }
            else if (Titulacao == 2)
            {
                valorPago = HS * 20;
            }
            else if (Titulacao == 3)
            {
                valorPago = HS * 30;
            }
            else
            {
                Console.WriteLine("Por Favor, digite uma opção Válida (1,2 ou 3).");
            }
        }while(Titulacao != 1 && Titulacao!=2 && Titulacao != 3);
        //calculo INSS.
        if(valorPago>151 && valorPago < 256)
        {
            valorPago = valorPago*0.92F;
        }
        else if(valorPago > 256 && valorPago < 510)
        {
            valorPago = valorPago * 0.91F;
        }
        else if (valorPago > 510.01 && valorPago < 1200)
        {
            valorPago = valorPago * 0.90F;
        }
        else if (valorPago > 1200)
        {
            valorPago = valorPago * 0.89F;
        }
        //IR
        if (valorPago > 800.01 && valorPago<1200)
        {
            valorPago = valorPago * 0.9F;
        }
        if (valorPago > 1200.01 && valorPago < 2400)
        {
            valorPago = valorPago * 0.85F;
        }
        if (valorPago > 2400.01 && valorPago < 3200)
        {
            valorPago = valorPago * 0.80F;
        }
        if (valorPago > 3200 && valorPago < 5750)
        {
            valorPago = valorPago * 0.75F;
        }
        if (valorPago > 5750)
        {
            valorPago = valorPago * 0.725F;
        }
        Console.WriteLine($"Professor: {NomeDoProfessor}\nMatrícula:{Matricula}\nValor a receber:{valorPago}");
    }
}
