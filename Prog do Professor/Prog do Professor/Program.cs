using System;
using System.IO;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        //Manipulador do arquivo:
        FileStream meuArq = new FileStream("C:\\Users\\mathe\\source\\repos\\Matheus-Emanoel-Souza\\exe.csharp\\Prog do Professor\\Prog do Professor\\numeros.txt", FileMode.Open, FileAccess.Read);
        StreamReader leitor = new StreamReader(meuArq, Encoding.UTF8);

        int cont = 1, soma = 0;
        while (!leitor.EndOfStream)
        {
            string linhaTxT = leitor.ReadLine();
            Console.WriteLine("Linha" + cont + ":" + linhaTxT);

            int num = int.Parse(linhaTxT);
            soma += num;

            cont++;
        }

        Console.WriteLine("Valor da Soma: {0}", soma);

        leitor.Close();
        meuArq.Close();

    }
}