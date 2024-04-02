using System;
using System.Collections.Generic;

class Conta
{
    // Propriedades da conta
    public int NumeroConta { get; set; }
    public double ValorConta { get; set; }
    public string NomeBanco { get; set; }
    public bool CreditoDisponivel { get; set; }

    // Construtor da classe Conta
    public Conta(int numeroConta, double valorConta, string nomeBanco, bool creditoDisponivel)
    {
        NumeroConta = numeroConta;
        ValorConta = valorConta;
        NomeBanco = nomeBanco;
        CreditoDisponivel = creditoDisponivel;
    }
}

class Program
{
    static void Apresentacao()
    {
        Console.WriteLine("Bem Vindo ao programa de controle Financeiro!!!");
    }
    static  int ListaDeEscolhas()
    {
        Console.WriteLine("Digite 1 para Registrar uma conta.");
        Console.WriteLine("Digite 2 para Mostrar uma conta.");
        Console.WriteLine("Digite 3 para Deletar uma conta.");
        int escolha = int.Parse(Console.ReadLine()!);
        return escolha;

    }

    static void Main(string[] args)
    {
        // Criando uma lista para armazenar várias contas
        List<Conta> listaContas = new List<Conta>();

        // Adicionando algumas contas à lista (apenas para demonstração)
        listaContas.Add(new Conta(12345, 1000.0, "Banco A", true));
        listaContas.Add(new Conta(54321, 2000.0, "Banco B", false));
        listaContas.Add(new Conta(98765, 3000.0, "Banco C", true));

        Apresentacao();

        int escolhar = ListaDeEscolhas();

        switch (escolhar)
        {
            case 1: Console.WriteLine("Você Deseja Registrar uma conta!");
                RegistraConta(listaContas);
                break;
            case 2: 
                Console.WriteLine("Você escolheu a opção 2");

                break;
            case 3: Console.WriteLine("Você escolheu a opção 3");
                break;
        }
        static void RegistraConta(List<Conta> listaContas)
        {
            Console.WriteLine("Por favior, insira os detalhes de uma nova conta:");
            Console.WriteLine("Número da conta:");
            int numeroConta = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Valor da conta:");
            double valorConta = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Digite o nome do banco");
            string nomeBanco = Console.ReadLine()!;
            Console.WriteLine("Função crédito está disponível ? (TRUE/FALSE):");
            bool creditoDiponivel = bool.Parse(Console.ReadLine()!);

            Conta novaConta = new Conta(numeroConta, valorConta, nomeBanco, creditoDiponivel);

            listaContas.Add(novaConta);
            Console.WriteLine("Conta Registrada com sucesso!!!");
            Console.Clear();
            ListaDeEscolhas();
        }

        static void ConsultarConta()
        {
            Console.Clear();
            Console.WriteLine("Digite o número da conta que deseja consultar:");
            int numeroConta = int.Parse(Console.ReadLine());
            ConsultarContaPorNumero(listaContas, numeroConta);
            static void ConsultarContaPorNumero(List<Conta> contas, int numeroConta)
            {
                // Procurando a conta na lista pelo número de conta
                Conta conta = contas.Find(c => c.NumeroConta == numeroConta);

                // Verificando se a conta foi encontrada
                if (conta != null)
                {
                    Console.WriteLine($"Número da Conta: {conta.NumeroConta}");
                    Console.WriteLine($"Valor da Conta: R$ {conta.ValorConta}");
                    Console.WriteLine($"Nome do Banco: {conta.NomeBanco}");
                    Console.WriteLine($"Crédito Disponível: {(conta.CreditoDisponivel ? "Sim" : "Não")}");
                }
                else
                {
                    Console.WriteLine("Conta não encontrada.");
                }
            }

        }
        



    }
    

}
