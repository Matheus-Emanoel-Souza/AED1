using System;
using System.IO;
class program
{
    static void Main()
    {
        string caminho = @"C:\Users\matheus.souza\Desktop\Algoritmos_Estrutura_de_Dados\Manipulação_de_Arquivos\EX_1\ex_1";
        string caminho_e_carquivo = Path.Combine(caminho+"texto.txt");
        try
        {
            if (!Directory.Exists(caminho_e_carquivo))
            {
                Directory.CreateDirectory(caminho);
                Console.WriteLine("Diretório criado");
            }
            else
            {
                Console.WriteLine("JÁ EXISTE UM ARQUIVO!!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("ocorreu um erro"+ ex.Message);
        }
        using (StreamWriter escreve_no_arquivo = new StreamWriter(caminho_e_carquivo))
        {
            escreve_no_arquivo.WriteLine(Console.ReadLine());
            Console.WriteLine("escrito com sucesso");
        }
        
    }
}