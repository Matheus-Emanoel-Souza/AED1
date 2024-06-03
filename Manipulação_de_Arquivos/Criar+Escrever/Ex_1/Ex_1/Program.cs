using System;
using System.IO;
class Program
{
    static void Main()
    {
        String diretorio = @"C:\Users\matheus.souza\Desktop\Algoritmos_Estrutura_de_Dados\Manipulação_de_Arquivos";
        string filepath = Path.Combine(diretorio, "lista_de_vilões.txt");

        try
        {
            if (!Directory.Exists(filepath))
            {
                Directory.CreateDirectory(diretorio);
                Console.WriteLine("diretório criado:" + diretorio);
            }
            using (StreamWriter escrever = new StreamWriter(filepath))
            {
                escrever.WriteLine("este é o conteudo do arquivo");
                Console.WriteLine("Arquivo criado com sucesso:" + filepath);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("ocorreu um erro" + ex.Message);
        }
    }
}