using System;
class program
{
    static void Main()
    {
        Exibir_questoes();
        static void op_1()
        {
            Console.Write("Digite o 1º número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 3º número: ");
            int numero3 = int.Parse(Console.ReadLine());

            int maior = numero1;

            if (numero2 > maior)
            {
                maior = numero2;
            }

            if (numero3 > maior)
            {
                maior = numero3;
            }

            Console.WriteLine($"O maior número é: {maior}");
        }
        static void op_2()
        {
            Console.Write("Digite o 1º número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 3º número: ");
            int numero3 = int.Parse(Console.ReadLine());

            int intermediario;

            if ((numero1 > numero2 && numero1 < numero3) || (numero1 > numero3 && numero1 < numero2))
            {
                intermediario = numero1;
            }
            else if ((numero2 > numero1 && numero2 < numero3) || (numero2 > numero3 && numero2 < numero1))
            {
                intermediario = numero2;
            }
            else
            {
                intermediario = numero3;
            }

            Console.WriteLine($"O número intermediário é: {intermediario}");
        }
        static void op_3()
        {
            Console.Write("Digite o 1º número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2º número: ");
            int num2 = int.Parse(Console.ReadLine());

            int temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine($"Após a troca, o valor de num1 é: {num1}");
            Console.WriteLine($"Após a troca, o valor de num2 é: {num2}");
        }
        static void op_4()
        {
            Console.Write("Por favor, insira um valor de hora (0-23): ");
            int hora;

            if (int.TryParse(Console.ReadLine(), out hora))
            {
                if (hora >= 0 && hora <= 23)
                {
                    if (hora >= 6 && hora < 12)
                    {
                        Console.WriteLine("Bom dia!");
                    }
                    else if (hora >= 12 && hora < 18)
                    {
                        Console.WriteLine("Boa tarde!");
                    }
                    else
                    {
                        Console.WriteLine("Boa noite!");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, insira um valor de hora válido entre 0 e 23.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida! Por favor, insira um número inteiro.");
            }
        }
        static void op_5() 
        {
            Console.Write("Digite a nota da N1: ");
            double n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da N1: ");
            double pesoN1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota da N2: ");
            double n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso da N2: ");
            double pesoN2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota do Exame Semestral: ");
            double exameSemestral = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o peso do Exame Semestral: ");
            double pesoExame = Convert.ToDouble(Console.ReadLine());

            double media = ((n1 * pesoN1) + (n2 * pesoN2) + (exameSemestral * pesoExame)) / (pesoN1 + pesoN2 + pesoExame);

            Console.WriteLine($"A nota final do aluno é: {media}");

            if (media >= 5.0)
            {
                Console.WriteLine("Aluno Aprovado!");
            }
            else if (media >= 4.0 && media < 5.0)
            {
                Console.WriteLine("Aluno pode fazer o Exame Suplementar.");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado.");
            }
        }
        static void op_6()
        {
            Console.WriteLine("Escolha a figura para a qual quer calcular a área:");
            Console.WriteLine("1. Retângulo");
            Console.WriteLine("2. Triângulo");
            Console.WriteLine("3. Circunferência");
            Console.Write("Opção: ");

            int opcao = Convert.ToInt32(Console.ReadLine());
            

            switch (opcao)
            {
                case 1:
                    CalcularAreaRetangulo();
                    break;
                case 2:
                    CalcularAreaTriangulo();
                    break;
                case 3:
                    CalcularAreaCircunferencia();
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }



            static void CalcularAreaRetangulo()
            {
                Console.Write("Digite a base do retângulo: ");
                double baseRetangulo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura do retângulo: ");
                double alturaRetangulo = Convert.ToDouble(Console.ReadLine());

                double area = baseRetangulo * alturaRetangulo;
                Console.WriteLine($"A área do retângulo é: {area}");
            }

            static void CalcularAreaTriangulo()
            {
                Console.Write("Digite a base do triângulo: ");
                double baseTriangulo = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite a altura do triângulo: ");
                double alturaTriangulo = Convert.ToDouble(Console.ReadLine());

                double area = (baseTriangulo * alturaTriangulo) / 2;
                Console.WriteLine($"A área do triângulo é: {area}");
            }

            static void CalcularAreaCircunferencia()
            {
                double PI = 3.141592;
                Console.Write("Digite o raio da circunferência: ");
                double raio = Convert.ToDouble(Console.ReadLine());

                double area = PI * raio * raio;
                Console.WriteLine($"A área da circunferência é: {area}");
            }
        }
        static void op_7()
        {
            Console.WriteLine("Calculadora de Salário Líquido Mensal para Professores da UCL");

            Console.Write("Número de Matrícula: ");
            string matricula = Console.ReadLine();

            Console.Write("Número de Horas Semanais: ");
            int horasSemanais = Convert.ToInt32(Console.ReadLine());

            Console.Write("Titulação (E - Especialista, M - Mestre, D - Doutor): ");
            char titulacao = char.Parse(Console.ReadLine()!);

            double valorHora = ObterValorHora(titulacao, horasSemanais);
            double salarioBruto = CalcularSalarioBruto(horasSemanais, valorHora);
            double inss = CalcularINSS(salarioBruto);
            double salarioBase = salarioBruto - inss;
            double ir = CalcularIR(salarioBase);
            double salarioLiquido = salarioBase - ir;

            Console.WriteLine();
            Console.WriteLine("Salário Bruto: R$ {0:F2}", salarioBruto);
            Console.WriteLine("Desconto INSS: R$ {0:F2}", inss);
            Console.WriteLine("Desconto IR: R$ {0:F2}", ir);
            Console.WriteLine("Salário Líquido: R$ {0:F2}", salarioLiquido);


            static double ObterValorHora(char titulacao, int horashorasSemanais)
            {
                switch (titulacao)
                {
                    case 'E':
                        return 15 * horashorasSemanais;
                    case 'M':
                        return 20 * horashorasSemanais;
                    case 'D':
                        return 30 * horashorasSemanais;
                    default:
                        Console.WriteLine("Titulo inválido!");
                        return 0;
                        op_7();
                }
            }

            static double CalcularSalarioBruto(int horasSemanais, double valorHora)
            {
                double salarioBruto = horasSemanais * valorHora * 4; // Considerando 4 semanas no mês
                salarioBruto *= 1.15; // Adicionando 15% de planejamento
                return salarioBruto;
            }

            static double CalcularINSS(double salarioBruto)
            {
                if (salarioBruto <= 256.00)
                    return salarioBruto * 0.08;
                else if (salarioBruto <= 510.00)
                    return salarioBruto * 0.09;
                else if (salarioBruto <= 1200.00)
                    return salarioBruto * 0.10;
                else
                    return salarioBruto * 0.11;
            }

            static double CalcularIR(double salarioBase)
            {
                if (salarioBase <= 800.00)
                    return 0;
                else if (salarioBase <= 1200.00)
                    return salarioBase * 0.10;
                else if (salarioBase <= 2400.00)
                    return salarioBase * 0.15;
                else if (salarioBase <= 3200.00)
                    return salarioBase * 0.20;
                else if (salarioBase <= 5750.00)
                    return salarioBase * 0.25;
                else
                    return salarioBase * 0.275;
            }
        }


        void Exibir_questoes()
        {
            while (true)
            {
                Console.WriteLine("Qual função deseja fazer ?");
                Console.WriteLine("1-recebe 3 números e imprime na tela o maior dos 3 números");
                Console.WriteLine("2-recebe 3 números e imprime na tela o número intermediário");
                Console.WriteLine("3-recebe 2 números nas variáreis num1 e num2 e em seguida troque o valor das duas variáveis");
                Console.WriteLine("4-recebe um número inteiro representando um valor de hora e exibe uma saudação para o usuário");
                Console.WriteLine("5-Nota dos alunos");
                Console.WriteLine("6-cálculo da área de formas geométricas");
                Console.WriteLine("7-calcular o salário líquido mensal dos professores da faculdade");
                int opcao = int.Parse(Console.ReadLine()!);
                switch (opcao)
                {
                    case 1:
                        op_1();
                        break;
                    case 2:
                        op_2();
                        break;
                    case 3:
                        op_3();
                        break;
                    case 4:
                        op_4();
                        break;
                    case 5:
                        op_5();
                        break;
                    case 6:
                        op_6();
                        break;
                    case 7:
                        op_7();
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente");
                        Console.Clear();
                        break;
                }
            }
        }
    }
}