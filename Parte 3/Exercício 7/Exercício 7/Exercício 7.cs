using System;

class Program
{
    static void Main()
    {

        bool continuar = true;
        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("INICIO DO PROGRAMA!!");
            //                 ENTRADA DE DADOS
            Console.WriteLine("Informe: O NOME DO PROFESSOR. ");
            string nomedoprofessor = Console.ReadLine();
            Console.WriteLine($"Informe: A matrícula do {nomedoprofessor}");
            float matricula = float.Parse(Console.ReadLine());
            Console.WriteLine($"Quantas horas semanais o {nomedoprofessor} ({matricula}) trabalhou na semana?");
            float hs = float.Parse(Console.ReadLine());
            Console.WriteLine($"Informe a titulação do {nomedoprofessor} ({matricula}).\n1.ESPECIALISTA\n2.MESTRE\n3.DOUTOR");
            int titulacão = int.Parse(Console.ReadLine());

            //CALCULANDO O SALÁRIO
            float salbrutu;
            float valhora = 0;
            if (titulacão==1) 
            {
                valhora = 15;
            }
            if (titulacão == 2)
            {
                valhora = 20;
            }
            if (titulacão == 3)
            {
                valhora = 30;
            }
            salbrutu = (hs * 4f * valhora) * 1.15f;
            float salLiquido;
            float descontosINSS = 0;
            //INSS
            if (salbrutu>=151  && salbrutu <= 256)
            {
                descontosINSS = salbrutu * 0.08f;
            }
            if (salbrutu >= 256.01 && salbrutu <= 510)
            {
                descontosINSS = salbrutu * 0.09f;
            }
            if (salbrutu >= 510.01 && salbrutu <= 1200)
            {
                descontosINSS = salbrutu * 0.1f;
            }
            if (salbrutu >1200)
            {
                descontosINSS = salbrutu * 0.11f;
            }
            float saldescINSS = salbrutu - descontosINSS;
            float descIR = 0;
            //IMPOSTO DE RENDA
            if (saldescINSS >= 801.01F && saldescINSS <= 1200)
            {
                descIR = saldescINSS * 0.1F;
            }
            if (saldescINSS >= 1200.01 && saldescINSS <= 2400)
            {
                descIR = saldescINSS * 0.15F;
            }
            if (saldescINSS >= 2400.01 && saldescINSS <= 3200)
            {
                descIR = saldescINSS * 0.20F;
            }
            if (saldescINSS >= 3200.01 && saldescINSS <= 5750)
            {
                descIR = saldescINSS * 0.25F;
            }
            if (saldescINSS > 5750)
            {
                descIR = saldescINSS * 0.275F;
            }
            salLiquido = salbrutu - (descIR + descontosINSS);
            //RETORNO
            string titulacaonome = " antes de mudar"; 
            if (titulacão == 1)
            {
                 titulacaonome = (string)"Especialista";
            }
            if (titulacão == 2)
            {
                 titulacaonome = (string)"Mestre";
            }
            if (titulacão == 3)
            {
                 titulacaonome = (string)"Doutor";
            }

            Console.WriteLine($"Professor: {nomedoprofessor} \nMatrícula:{matricula}\nTítulo de: {titulacaonome} \nReceberá o seguinte salário:{salLiquido};");
            Console.WriteLine($"\n\nSegue os descontos:\nSALÁRIO BRUTU:{salbrutu}\nINSS:{descontosINSS}\nIMPOSTO DE RENDA:{descIR}\nSALÁRIO LÍQUIDO:{salLiquido}");

            Console.WriteLine("Você deseja repetir o programa ? s/n");
            if (Console.ReadLine()== "n"|| Console.ReadLine() == "N" || Console.ReadLine() == "Não" || Console.ReadLine() == "Nao" || Console.ReadLine() == "nao")
            {
                continuar = false;
            }
        }
    }
} 
