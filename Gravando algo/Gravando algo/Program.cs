using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "texto.txt";



        try
        {
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                string texto = "Este é um exemplo de texto que será escrito no arquivo.";
                byte[] bytes = Encoding.UTF8.GetBytes(texto);

                fileStream.Write(bytes, 0, bytes.Length);

                Console.WriteLine("Texto escrito no arquivo com sucesso!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
