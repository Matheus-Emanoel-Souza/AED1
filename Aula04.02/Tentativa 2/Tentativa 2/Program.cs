using System;
class Program
{
    class Pessoa
    {
        public string nome;
        public int idade;
        public float altura;
        public float peso;

        public bool maiorDeidade()
        {
            if (idade >= 18) 
            { 
                return true;
            }else
                return false; 
    }
    static void Main()
    {
        static void InformaPessoa()
            {
                Console.WriteLine("Informe os dados da pessoa!!");
                Console.WriteLine("Qual o nome da pessoa ?");
                string Nomedapessoa = Console.ReadLine()!;
                Console.WriteLine("Qual a idade da pessoa?");
                int idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a altura da pessoa");
                float altura = float.Parse(Console.ReadLine()!);
                Console.WriteLine("Informe o peso da pessoa");
                float peso = float.Parse(Console.ReadLine()!);
                Pessoa pessoa1 = new Pessoa { nome = Nomedapessoa, idade = idade, altura = altura, peso = peso };
                Console.WriteLine("Pessoa informada com sucesso!!");
            }
        static void Opçoes()
            {
                
            }
            InformaPessoa();


        
    }
}